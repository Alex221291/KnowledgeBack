namespace dsKnowledgeTest.Models
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime CreateData { get; set; }

    }
}
