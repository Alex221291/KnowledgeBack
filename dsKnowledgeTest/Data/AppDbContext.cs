using dsKnowledgeTest.Data.Init;
using dsKnowledgeTest.Models;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(UserData.Administrator);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Test> Tests { get; set; }
    public DbSet<Faq> Faq { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<PassedTest> PassedTests { get; set; }
    public DbSet<AnsweredQuestion> AnsweredQuestions { get; set; }
}