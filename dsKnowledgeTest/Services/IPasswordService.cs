using System.Security.Cryptography;
using System.Text;
using dsKnowledgeTest.ViewModels.PasswordViewModels;

namespace dsKnowledgeTest.Services
{
    public interface IPasswordService
    {
        public Task<PasswordViewModel> GeneratePassword();
    }

    public class PasswordService : IPasswordService
    {
        public Task<PasswordViewModel> GeneratePassword()
        {
            var password = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                password.Append(random.Next(10).ToString());
            }

            var hashPassword = HaspPassword(password.ToString());

            return Task.FromResult(new PasswordViewModel
            {
                Password = password.ToString(),
                HashPassword = hashPassword
            });
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
