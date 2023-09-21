using System.ComponentModel.DataAnnotations.Schema;

namespace dsKnowledgeTest.Models
{
    public class AnsweredQuestion
    {
        public Guid Id { get; set; }
        [NotMapped]
        public List<string?>? ListSelectedAnswers
        {
            get
            {
                return this.SelectedAnswers.Split("@#$").ToList();
            }
            set
            {
                this.SelectedAnswers = string.Join("@#$", value);
            }
        }
        public string? SelectedAnswers { get; set; }
        public int? Score { get; set; }

        public Guid? PassedTestId { get; set; }
        public PassedTest? PassedTest { get; set; }

        public Guid? QuestionId { get; set; }
        public Question? Question { get; set; }

    }
}
