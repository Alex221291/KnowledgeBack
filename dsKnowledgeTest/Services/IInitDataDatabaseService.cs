using dsKnowledgeTest.Data;
using dsKnowledgeTest.Data.Init;

namespace dsKnowledgeTest.Services
{
    public interface IInitDataDatabaseService
    { 
        public Task<string> InitDataDatabaseAsync();
    }

    public class InitDataDataBaseService : IInitDataDatabaseService
    {
        private readonly AppDbContext _db;

        public InitDataDataBaseService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<string> InitDataDatabaseAsync()
        {
            await using var transaction = await _db.Database.BeginTransactionAsync();
            try
            {
                await _db.Faq.AddRangeAsync(FaqData.Faqs);
                await _db.Categories.AddRangeAsync(CategoryData.Categories);
                await _db.Tests.AddRangeAsync(TestData.Tests);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsJavaScriptTest);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsAlgorithmizationTest);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsTestingTest);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsJavaTest);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsKotlinTest);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsPythonTest);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsHtmlTest);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsCssTest);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsBusinessAnalysisTest);
                await _db.Questions.AddRangeAsync(QuestionData.QuestionsForBasicsCSharpTest);
                await _db.SaveChangesAsync();
                await transaction.CommitAsync();
                return "Данные добавлены успешно";
            }
            catch
            {
                await transaction.RollbackAsync();
                return "Данные не добавлены";
            }
        }
    }
}
