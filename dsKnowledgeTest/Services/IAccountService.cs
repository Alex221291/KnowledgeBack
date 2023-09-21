using System.Security.Cryptography;
using System.Text;
using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Data;
using dsKnowledgeTest.Models;
using dsKnowledgeTest.ViewModels.UserViewModels;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Services
{
    public interface IAccountService
    {
        public Task<UserViewModel?> Login(LoginUserViewModel loginUser);
        public Task<UserViewModel?> Register(RegisterUserViewModel registerUser, string hashPassword);
    }

    public class AccountService : IAccountService
    {
        public const int EMAIL_MIN_LENGHT = 6;

        private readonly AppDbContext _db;

        public AccountService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<UserViewModel?> Login(LoginUserViewModel loginUser)
        {
            try
            {
                var user = await _db.Users.AsNoTracking()
                    .Select(u => new UserViewModel
                    {
                        Id = u.Id.ToString(),
                        Email = u.Email,
                        Login = u.Login,
                        Password = u.Password,
                        FirstName = u.FirstName,
                        SurName = u.SurName,
                        LastName = u.LastName,
                        IconUrl = u.IconUrl,
                        Organization = u.Organization,
                        Specialization = u.Specialization,
                        PhoneNumber = u.PhoneNumber,
                        RoleName = u.Role.ToString(),
                        IsActivated = u.IsActivated,
                        Token = ""
                    }).FirstOrDefaultAsync(u =>
                        u.Email == loginUser.Email && u.Password == HaspPassword(loginUser.Password));
                return user?.IsActivated == true
                    ? user
                    : null;
            }
            catch
            {
                return null;
            }
        }

        public async Task<UserViewModel?> Register(RegisterUserViewModel registerUser, string hashPassword)
        {
            try
            {
                if (registerUser.Email.Length < EMAIL_MIN_LENGHT) return null;

                await _db.Users.AddAsync(new User
                {
                    FirstName = registerUser.FirstName,
                    LastName = registerUser.LastName,
                    SurName = registerUser.SurName,
                    Organization = registerUser.Organization,
                    Specialization = registerUser.Specialization,
                    PhoneNumber = registerUser.PhoneNumber,
                    Email = registerUser.Email,
                    Password = hashPassword,
                    DataCreated = DateTime.UtcNow,
                    DataUpdated = DateTime.UtcNow,
                    Role = RolesConst.User,
                    IsActivated = true,
                    IsDeleted = false,
                    
                });
                await _db.SaveChangesAsync();

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
                    .FirstOrDefaultAsync(u => u.Email == registerUser.Email);
            }
            catch
            {
                return null;
            }
        }

        private static string HaspPassword(string password)
        {
            var md5 = MD5.Create();
            var b = Encoding.ASCII.GetBytes(password);
            var hash = md5.ComputeHash(b);
            var sb = new StringBuilder();
            foreach (var a in hash)
                sb.Append(a.ToString("X2"));
            return sb.ToString();
        }
    }
}
