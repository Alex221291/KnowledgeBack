using dsKnowledgeTest.Constants;

namespace dsKnowledgeTest.ViewModels.QuestionViewModels
{
    public class CreateQuestionWithoutTestIdViewModel
    {
        public string Name { get; set; }
        public string? QuestionType { get; set; }
        public int NumberOfPoints { get; set; }
        public string IconUrl { get; set; }

        public List<string?>? Answers { get; set; }
        public List<string?>? TrueAnswers { get; set; }
    }
}
