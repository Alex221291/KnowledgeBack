namespace dsKnowledgeTest.Models
{
    public class PassedTest
    {
        public Guid Id { get; set; }
        public string? TimeSpent { get; set; }
        public string? Status { get; set; }
        public DateTime DateOfPassage { get; set; }
        public double? Score { get; set; }

        

        public Guid? TestId { get; set; }
        public Test? Test { get; set; }

        public Guid? UserId { get; set; }
        public User? User { get; set; }

        public List<AnsweredQuestion>? AnsweredQuestions { get; set; }
    }
}
