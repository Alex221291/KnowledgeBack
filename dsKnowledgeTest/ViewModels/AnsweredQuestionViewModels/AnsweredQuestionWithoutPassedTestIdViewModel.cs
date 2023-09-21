namespace dsKnowledgeTest.ViewModels.AnsweredQuestionViewModels
{
    public class AnsweredQuestionWithoutPassedTestIdViewModel
    {
        public string Id { get; set; }
        public List<string?>? ListSelectedAnswers { get; set; }
        public List<string?>? ListAnswers { get; set; }
        public List<string?>? ListTrueAnswers { get; set; }
        public int? Score { get; set; }
        public string? QuestionId { get; set; }
    }
}
