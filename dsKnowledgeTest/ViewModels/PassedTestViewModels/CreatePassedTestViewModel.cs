using dsKnowledgeTest.ViewModels.AnsweredQuestionViewModels;

namespace dsKnowledgeTest.ViewModels.PassedTestViewModels
{
    public class CreatePassedTestViewModel
    {
        public string? TimeSpent { get; set; }
        public string? Status { get; set; }
        public double? Score { get; set; }
        public string? TestId { get; set; }
        public string? UserId { get; set; }
        public List<CreateAnsweredQuestionWithoutPassedTestIdViewModel>? AnsweredQuestions { get; set; }
    }
}
