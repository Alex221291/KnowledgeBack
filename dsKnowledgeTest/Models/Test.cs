using dsKnowledgeTest.Constants;

namespace dsKnowledgeTest.Models;

public class Test
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public TestType? TestType { get; set; }
    public TestLevel? TestLevel { get; set; }
    public bool? IsTestOnTime { get; set; }
    public int? TimeForTest { get; set; }
    public int? Score { get; set; }
    public double? MinThreshold { get; set; }
    public int? CntQuestion { get; set; }
    public bool? IsDeleted { get; set; }
    public bool? IsRandomQuestions { get; set; }
    public bool? IsRandomAnswers { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    public Guid? CategoryId { get; set; }
    public Category? Category { get; set; }

    public List<Question>? Questions { get; set; }

    public List<PassedTest>? PassedTests { get; set; }

}