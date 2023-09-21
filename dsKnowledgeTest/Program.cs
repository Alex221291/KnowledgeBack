using System.Text;
using dsKnowledgeTest.Data;
using dsKnowledgeTest.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            // указывает, будет ли валидироваться издатель при валидации токена
            ValidateIssuer = true,
            // строка, представляющая издателя
            ValidIssuer = AuthOptions.ISSUER,
            // будет ли валидироваться потребитель токена
            ValidateAudience = true,
            // установка потребителя токена
            ValidAudience = AuthOptions.AUDIENCE,
            // будет ли валидироваться время существования
            ValidateLifetime = true,
            // установка ключа безопасности
            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            // валидация ключа безопасности
            ValidateIssuerSigningKey = true,
        };
    });


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigin", build => build.AllowAnyOrigin());
    options.AddPolicy("AllowAnyMethod", build => build.AllowAnyMethod());
    options.AddPolicy("AllowAnyHeader", build => build.AllowAnyHeader());
});

builder.Services.AddControllers();

builder.Services.AddSingleton(Path.Combine(Directory.GetCurrentDirectory(), "test_template.xlsx"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") 
                 ?? builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine(connection);
//service for PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connection));
//builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<ITestService, TestService>();
builder.Services.AddTransient<IAccountService, AccountService>();
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<IFaqService, FaqService>();
builder.Services.AddTransient<IFeedbackService, FeedbackService>();
builder.Services.AddTransient<IQuestionService, QuestionService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IAnsweredQuestionService, AnsweredQuestionService>();
builder.Services.AddTransient<IPassedTestService, PassedTestService>();
builder.Services.AddTransient<IPasswordService, PasswordService>();
builder.Services.AddTransient<IInitDataDatabaseService, InitDataDataBaseService>();
builder.Services.AddTransient<IExcelParserService, ExcelParserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(build => build.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());

app.UseAuthentication();

app.UseAuthorization();

app.UseDirectoryBrowser();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.MapControllers();

app.Run();

public class AuthOptions
{
    public const string ISSUER = "MyAuthServer"; // издатель токена
    public const string AUDIENCE = "MyAuthClient"; // потребитель токена
    const string KEY = "mysupersecret_secretkey!123";   // ключ для шифрации
    public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
}