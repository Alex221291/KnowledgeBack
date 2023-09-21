using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.UserViewModels;
using AppDbContext = dsKnowledgeTest.Data.AppDbContext;

namespace dsKnowledgeTest.Tests
{
    public class AccountServiceTests
    {
        private readonly AppDbContext _context;

        public AccountServiceTests()
        {
            _context = ContextGenerator.Generate();
        }

        [Fact]
        public async Task Login_AllTests()
        {
            var validVm = new LoginUserViewModel
            {
                Email = "lukanevam@gmail.com",
                Password = "12345678"
            };
            var invalidPasswordVm = new LoginUserViewModel
            {
                Email = "lukanevam@gmail.com",
                Password = "1234567"
            };
            var invalidLoginVm = new LoginUserViewModel
            {
                Email = "lukanevam1@gmail.com",
                Password = "12345678"
            };

            await _context.Users.AddRangeAsync(MockData.users);

            await _context.SaveChangesAsync();

            var accountService = new AccountService(_context);

            var result = await accountService.Login(validVm);
            var result1 = await accountService.Login(invalidPasswordVm);
            var result2 = await accountService.Login(invalidLoginVm);

            Assert.Equal(MockData.lukanev.Id.ToString(), result.Id);
            Assert.Equal(null, result1);
            Assert.Equal(null, result2);
        }

        [Fact]
        public async Task Register_AllTests()
        {
            var hashpassword = "25D55AD283AA400AF464C76D713C07AD";
            var validVm = new RegisterUserViewModel
            {
                Email = "lukanev@gmail.com"
            };
            
            await _context.Users.AddRangeAsync(MockData.users);

            await _context.SaveChangesAsync();

            var accountService = new AccountService(_context);

            var result = await accountService.Register(validVm, hashpassword);

            Assert.Equal(validVm.Email, result.Email);
        }
    }
}
