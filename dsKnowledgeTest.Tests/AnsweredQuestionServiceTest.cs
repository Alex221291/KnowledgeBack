using dsKnowledgeTest.Data;
using dsKnowledgeTest.Services;

namespace dsKnowledgeTest.Tests
{
    public class AnsweredQuestionServiceTest
    {
        private readonly AppDbContext _context;
        public AnsweredQuestionServiceTest()
        {
            _context = ContextGenerator.Generate();
        }

        [Fact]
        public async Task GetAllByPassedTestId_AllTests()
        {
            var passedTestId = MockData.passedTest1.Id.ToString();

            var emptyPassedTestId = MockData.passedTest3.Id.ToString();

            await _context.AnsweredQuestions.AddRangeAsync(MockData.answeredQuestions);
            await _context.SaveChangesAsync();
            var answeredQuestionService = new AnsweredQuestionService(_context);
            var result = await answeredQuestionService.GetAllByPassedTestId(passedTestId);
            var emptyResult = await answeredQuestionService.GetAllByPassedTestId(emptyPassedTestId);

            Assert.Equal(3, result.Count);
            Assert.Equal(0, emptyResult.Count);

        }
    }
}
