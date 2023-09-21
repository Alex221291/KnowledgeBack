using dsKnowledgeTest.Data;
using dsKnowledgeTest.ViewModels.UserViewModels;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Services
{
    public interface IUserService
    {
        public Task EditUserAsync(UpdateUserViewModel model);
        public Task<UserViewModel?> GetByIdAsync(Guid userId);
    }

    public class UserService : IUserService
    {
        private readonly AppDbContext _db;

        public UserService(AppDbContext db)
        {
            _db = db;
        }

        public async Task EditUserAsync(UpdateUserViewModel model)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Id.ToString() == model.Id);

            if (user != null)
            {
                user.FirstName = model.FirstName ?? user.FirstName;
                user.SurName = model.SurName ?? user.SurName;
                user.LastName = model.LastName ?? user.LastName;
                user.Organization = model.Organization ?? user.Organization;
                user.Specialization = model.Specialization ?? user.Specialization;
                user.Email = model.Email ?? user.Email;
                user.PhoneNumber = model.PhoneNumber ?? user.PhoneNumber;
                user.DataUpdated = DateTime.UtcNow;
                user.IconUrl = model.IconUrl ?? user.IconUrl;

                _db.Users.Update(user);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<UserViewModel?> GetByIdAsync(Guid userId)
        {
            return await _db.Users.AsNoTracking()
                .Select(u => new UserViewModel
                {
                    Id = u.Id.ToString(),
                    Email = u.Email,
                    Login = u.Login,
                    Password = u.Password,
                    IsActivated = u.IsActivated,
                    FirstName = u.FirstName,
                    SurName = u.SurName,
                    LastName = u.LastName,
                    IconUrl = u.IconUrl,
                    Organization = u.Organization,
                    Specialization = u.Specialization,
                    PhoneNumber = u.PhoneNumber,
                    RoleName = u.Role.ToString(),
                    Token = ""
                })
                .FirstOrDefaultAsync(u => u.Id == userId.ToString());
        }
    }
}
