using dsKnowledgeTest.Data;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.UserViewModels;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Tests
{
    public class UserServiceTests
    {
        private readonly AppDbContext _context;

        public UserServiceTests()
        {
            _context = ContextGenerator.Generate();
        }

        [Fact]
        public async Task GetUserByIdAsync_AllTests()
        {
            var validId = MockData.lukanev.Id;
            var invalidId = Guid.NewGuid();

            await _context.Users.AddRangeAsync(MockData.users);
            await _context.SaveChangesAsync();

            var userService = new UserService(_context);

            var result = await userService.GetByIdAsync(validId);
            var result1 = await userService.GetByIdAsync(invalidId);

            Assert.Equal(validId.ToString(), result.Id);
            Assert.Equal(null, result1);
        }

        [Fact]
        public async Task EditUserAsync_AllTests()
        {
            var validModel = new UpdateUserViewModel
            {
                Id = MockData.lukanev.Id.ToString(),
                FirstName = "Сергей",
            };
            var invalidModel = new UpdateUserViewModel
            {
                Id = Guid.NewGuid().ToString(),

            };

            await _context.Users.AddRangeAsync(MockData.users);
            await _context.SaveChangesAsync();

            var userService = new UserService(_context);

            await userService.EditUserAsync(validModel);
            var result = await _context.Users
                .FirstOrDefaultAsync(u => u.Id.ToString() == validModel.Id);

            Assert.Equal(validModel.FirstName, result.FirstName);
        }
    }
}
