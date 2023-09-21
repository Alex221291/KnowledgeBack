using dsKnowledgeTest.Constants;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Models
{
    [Index("Email", IsUnique = true)]
    [Index("Login", IsUnique = true)]
    public class User
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? SurName { get; set; }
        public string? LastName { get; set; }
        public string? Organization { get; set; }
        public string? Specialization { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Login { get; set; }
        public string Password { get; set; }
        public string? IconUrl { get; set; }
        public DateTime DataCreated { get; set; }
        public DateTime DataUpdated { get; set; }
        public bool IsActivated { get; set; }
        public bool IsDeleted { get; set; }
        public RolesConst Role { get; set; }

        public List<PassedTest>? PassedTests { get; set; }

    }
}
