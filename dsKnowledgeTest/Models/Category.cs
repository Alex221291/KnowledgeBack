namespace dsKnowledgeTest.Models;

public class Category
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public int? CntTest { get; set; }
    public bool? IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    
    public List<Test>? Tests { get; set; }
}