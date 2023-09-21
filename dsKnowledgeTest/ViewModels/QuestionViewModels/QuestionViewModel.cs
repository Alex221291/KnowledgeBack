using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Models;

namespace dsKnowledgeTest.ViewModels.QuestionViewModels
{
    public class QuestionViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? QuestionType { get; set; }
        public int? NumberOfPoints { get; set; }
        public string? IconUrl { get; set; }

        public string? TestId { get; set; }
        public List<string?>? Answers { get; set; }
        public List<string?>? TrueAnswers { get; set; }
    }
}
