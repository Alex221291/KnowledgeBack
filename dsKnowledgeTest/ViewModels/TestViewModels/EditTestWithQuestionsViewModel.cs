using dsKnowledgeTest.Constants;
using dsKnowledgeTest.ViewModels.QuestionViewModels;

namespace dsKnowledgeTest.ViewModels.TestViewModels
{
    public class EditTestWithQuestionsViewModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? TestLevel { get; set; }
        public bool? IsTestOnTime { get; set; }
        public int? TimeForTest { get; set; }
        public int? Score { get; set; }
        public double? MinThreshold { get; set; }
        public string CategoryId { get; set; }
        public bool? IsRandomQuestions { get; set; }
        public bool? IsRandomAnswers { get; set; }
        public List<EditQuestionWithoutTestIdViewModel>? Questions { get; set; }
    }
}
