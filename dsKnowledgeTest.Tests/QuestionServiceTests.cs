using dsKnowledgeTest.Data;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.QuestionViewModels;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Tests
{
    public class QuestionServiceTests
    {
        private readonly AppDbContext _context;
        public QuestionServiceTests()
        {
            _context = ContextGenerator.Generate();
        }

        [Fact]
        public async Task GetAllQuestionForTestAsync_AllTests()
        {
            var testId = MockData.test1.Id;
            var badTestId = MockData.test2.Id;

            await _context.Questions.AddRangeAsync(MockData.questions);
            await _context.SaveChangesAsync();
            var questionService = new QuestionService(_context);

            var result = await questionService.GetAllQuestionForTestAsync(testId);
            var emptyResult = await questionService.GetAllQuestionForTestAsync(badTestId);
            Assert.Equal(2, result.Count);
            Assert.Equal(0, emptyResult.Count);

        }

        [Fact]
        public async Task GetQuestionByIdAsync_AllTests()
        {
            var questionId = MockData.question1.Id;
            var badQuestionId = Guid.NewGuid();

            await _context.Questions.AddRangeAsync(MockData.questions);
            await _context.SaveChangesAsync();
            var questionService = new QuestionService(_context);

            var result = await questionService.GetQuestionByIdAsync(questionId);
            var emptyResult = await questionService.GetQuestionByIdAsync(badQuestionId);
            Assert.Equal(questionId.ToString(), result.Id);
            Assert.Null(emptyResult);

        }

        [Fact]
        public async Task CreateQuestionAsync_AllTests()
        {
            var createQuestion = new CreateQuestionViewModel
            {
                Name = "Типы данных?",
                QuestionType = "ManyOfMany",
                NumberOfPoints = 10,
                IconUrl = "",
                TestId = MockData.test1.Id.ToString(),
                Answers = new() { "значемые", "ссылочные", "сборные" },
                TrueAnswers = new() { "значемые", "ссылочные" }
            };
            var questionService = new QuestionService(_context);

            await questionService.CreateQuestionAsync(createQuestion);
            var result = await _context.Questions.ToListAsync();
            
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public async Task EditQuestionAsync_AllTests()
        {
            var editQuestion = new EditQuestionViewModel()
            {
                Id = MockData.question1.Id.ToString(),
                Name = "Типы данных?",
                QuestionType = "ManyOfMany",
                NumberOfPoints = 10,
                IconUrl = "",
                TestId = MockData.test1.Id.ToString(),
                Answers = new() { "значемые", "ссылочные", "сборные" },
                TrueAnswers = new() { "значемые", "ссылочные" }
            };

            await _context.Questions.AddRangeAsync(MockData.questions);
            await _context.SaveChangesAsync();
            var questionService = new QuestionService(_context);

            await questionService.EditQuestionAsync(editQuestion);
            var result = await _context.Questions
                .FirstOrDefaultAsync(q => q.Id.ToString() == editQuestion.Id);

            Assert.Equal(editQuestion.Name, result.Name);
        }

        [Fact]
        public async Task DeleteQuestionAsync_AllTests()
        {
            var deleteQuestionId = MockData.question3.Id;

            await _context.Questions.AddRangeAsync(MockData.questions);
            await _context.SaveChangesAsync();
            var questionService = new QuestionService(_context);

            await questionService.DeleteQuestionAsync(deleteQuestionId);
            var result = await _context.Questions
                .FirstOrDefaultAsync(q => q.Id == deleteQuestionId);

            Assert.Equal(true, result.IsDeleted);
        }
    }
}
