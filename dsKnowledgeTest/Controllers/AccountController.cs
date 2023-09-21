using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace dsKnowledgeTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IEmailService _emailService;
        private readonly IPasswordService _passwordService;

        public AccountController(IAccountService accountService, IEmailService emailService, IPasswordService passwordService)
        {
            _accountService = accountService;
            _emailService = emailService;
            _passwordService = passwordService;
        }

        [Route("Login")]
        [HttpPost]
        public async Task<ObjectResult> Login(LoginUserViewModel loginUser)
        {
            var user = await _accountService.Login(loginUser);
            if (user == null) return BadRequest("Пользователь не найден");
            user.Token = await Authenticate(user);
            return Ok(user);
        }

        [Route("Register")]
        [HttpPost]
        public async Task<ObjectResult> Register(RegisterUserViewModel registerUser)
        {
            try
            {
                var passwordUser = await _passwordService.GeneratePassword();
                var user = await _accountService.Register(registerUser, passwordUser.HashPassword);
                if (user == null) return BadRequest("Данный email зарегистрирован.");
                await _emailService.SendEmailAsync(user.Email, "Пароль для входа", passwordUser.Password);
                return Ok(user);
            }
            catch
            {
                return BadRequest("Некорректный email.");
            }
        }

        private Task<string> Authenticate(UserViewModel user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.RoleName)
            };

            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(1440)), // время действия 1440 минут(сутки)
                signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(),
                    SecurityAlgorithms.HmacSha256));

            return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(jwt));
        }
    }
}