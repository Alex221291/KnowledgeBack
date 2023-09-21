using MimeKit;
using MailKit.Net.Smtp;

namespace dsKnowledgeTest.Services
{
    public interface IEmailService
    {
        public Task SendEmailAsync(string email, string subject, string message);
    }

    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "aleklukanev@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };
            using (var client = new SmtpClient())
            {
                Console.WriteLine("before conect " + client.IsConnected);
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                Console.WriteLine("after conect " + client.IsConnected);
                Console.WriteLine("before auth " + client.IsAuthenticated);
                await client.AuthenticateAsync("aleklukanev@yandex.ru", "qN8-6zS-YeV-dvL");
                Console.WriteLine("after auth " + client.IsAuthenticated);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }
    }
}
