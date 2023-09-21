using System.ComponentModel.DataAnnotations.Schema;
using dsKnowledgeTest.Constants;

namespace dsKnowledgeTest.Models;

public class Question
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Explanation { get; set; }
    public QuestionType QuestionType { get; set; }
    public int NumberOfPoints { get; set; }
    public string? IconUrl { get; set; }

    [NotMapped]
    public List<string?>? ListAnswers
    {
        get
        {
            return this.Answers.Split("@#$").ToList();
        }
        set
        {
            this.Answers = string.Join("@#$", value);
        }
    }

    public string? Answers { get; set; }
    [NotMapped]
    public List<string?>? ListTrueAnswers
    {
        get
        {
            return this.TrueAnswers.Split("@#$").ToList();
        }
        set
        {
            this.TrueAnswers = string.Join("@#$", value);
        }
    }
    public string? TrueAnswers { get; set; }
    public bool? IsDeleted { get; set; }

    public Guid? TestId { get; set; }
    public Test?  Test { get; set; }

    public List<AnsweredQuestion>? AnsweredQuestions { get; set; }
}