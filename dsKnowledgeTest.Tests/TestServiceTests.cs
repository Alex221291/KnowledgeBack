using dsKnowledgeTest.Data;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.TestViewModel;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Tests
{
    public class TestServiceTests
    {
        private readonly AppDbContext _context;

        public TestServiceTests()
        {
            _context = ContextGenerator.Generate();
        }

        [Fact]
        public async Task GetAllTestByCategoryAsync_AllTests()
        {
            var categoryId1 = MockData.category1.Id;
            var categoryId2 = MockData.category2.Id;
            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);
            await _context.Tests.AddRangeAsync(MockData.tests);
            await _context.SaveChangesAsync();

            var result = await testService.GetAllTestByCategoryAsync(categoryId1);
            var emptyResult = await testService.GetAllTestByCategoryAsync(categoryId2);
            
            Assert.Equal(1, result.Count);
            Assert.Equal(0, emptyResult.Count);
        }

        [Fact]
        public async Task CreateTestAsync_AllTests()
        {
            var createTest = new CreateTestViewModel
            {
                Name = "Циклы C#",
                TestLevel = "High",
                CategoryId = MockData.category1.Id.ToString(),
            };
            
            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);

            await testService.CreateTestAsync(createTest);
            var result = await _context.Tests
                .FirstOrDefaultAsync(t => t.Name == createTest.Name);

            Assert.Equal(createTest.Name, result.Name);
        }

        [Fact]
        public async Task EditTestAsync_AllTests()
        {
            var editTest = new EditTestViewModel
            {
                Id = MockData.test1.Id.ToString(),
                TestLevel = "High",
                Name = "Ветвления C#",
            };
            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);
            await _context.Tests.AddRangeAsync(MockData.tests);
            await _context.SaveChangesAsync();

            await testService.EditTestAsync(editTest);
            var result = await _context.Tests.FirstOrDefaultAsync(t => t.Id.ToString() == editTest.Id);

            Assert.Equal(editTest.Name, result.Name);
        }

        [Fact]
        public async Task DeleteTestAsync_AllTests()
        {
            var deleteTestId = MockData.test1.Id;
            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);
            await _context.Tests.AddRangeAsync(MockData.tests);
            await _context.SaveChangesAsync();

            await testService.DeleteTestAsync(deleteTestId);
            var result = await _context.Tests.FirstOrDefaultAsync(t => t.Id == deleteTestId);

            Assert.Equal(true, result.IsDeleted);
        }

        [Fact]
        public async Task SearchTestsAsync_AllTests()
        {
            var searchName1 = MockData.test3.Name;
            var searchName2 = MockData.test2.Name;
            var searchName3 = "";

            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);
            await _context.Tests.AddRangeAsync(MockData.tests);
            await _context.SaveChangesAsync();

            var result = await testService.SearchTestsAsync(searchName1);
            var emptyResult = await testService.SearchTestsAsync(searchName2);
            var fullResult = await testService.SearchTestsAsync(searchName3);

            Assert.Equal(1, result.Count);
            Assert.Equal(0, emptyResult.Count);
            Assert.Equal(2, fullResult.Count);
        }
    }
}
