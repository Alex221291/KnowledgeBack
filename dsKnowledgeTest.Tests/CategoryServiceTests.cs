using dsKnowledgeTest.Data;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.CategoryViewModels;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Tests
{
    public class CategoryServiceTests
    {
        private readonly AppDbContext _context;

        public CategoryServiceTests()
        {
            _context = ContextGenerator.Generate();
        }

        [Fact]
        public async Task GetAllCategoriesAsync_AllTests()
        {
            await _context.Categories.AddRangeAsync(MockData.categories);
            await _context.SaveChangesAsync();

            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);
            var categoryService = new CategoryService(_context, testService);

            var result = await categoryService.GetAllCategoriesAsync();

            Assert.NotEqual(MockData.categories.Count, result.Count());
        }

        [Fact]
        public async Task GetCategoryByIdAsync_AllTests()
        {
            await _context.Categories.AddRangeAsync(MockData.categories);
            await _context.SaveChangesAsync();

            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);
            var categoryService = new CategoryService(_context, testService);

            var result = await categoryService.GetCategoryByIdAsync(MockData.category1.Id);
            var emptyResult = await categoryService.GetCategoryByIdAsync(Guid.NewGuid());

            Assert.Equal(MockData.category1.Id.ToString(), result.Id);
            Assert.Equal(null, emptyResult);
        }

        [Fact]
        public async Task CreateCategoryAsync_AllTests()
        {
            var newCategory = new CreateCategoryViewModel
            {
                Name = "Математика",
                Description = "Царица наук",
                ImageUrl = null
            };

            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);
            var categoryService = new CategoryService(_context, testService);

            var countAfter = (await _context.Categories.ToListAsync()).Count;
            await categoryService.CreateCategoryAsync(newCategory);
            var countBefore = (await _context.Categories.ToListAsync()).Count;

            Assert.NotEqual(countAfter, countBefore);
        }

        [Fact]
        public async Task EditCategoryAsync_AllTests()
        {
            await _context.Categories.AddRangeAsync(MockData.categories);
            await _context.SaveChangesAsync();

            var editCategory = new EditCategoryViewModel
            {
                Id = MockData.category3.Id.ToString(),
                Name = "Физика",
                Description = "Царица наук",
                ImageUrl = null
            };

            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);
            var categoryService = new CategoryService(_context, testService);

            
            await categoryService.EditCategoryAsync(editCategory);

            var resCategory = await _context.Categories.FirstOrDefaultAsync(c => c.Id.ToString() == editCategory.Id);

            Assert.Equal(editCategory.Name, resCategory.Name);
        }

        [Fact]
        public async Task DeleteCategoryAsync_AllTests()
        {
            await _context.Categories.AddRangeAsync(MockData.categories);
            await _context.SaveChangesAsync();

            var deleteId = MockData.category1.Id;

            var questionService = new QuestionService(_context);
            var testService = new TestService(_context, questionService);
            var categoryService = new CategoryService(_context, testService);

            await categoryService.DeleteCategoryAsync(deleteId);

            var deleteCategory = await _context.Categories.FirstOrDefaultAsync(c => c.Id == deleteId);

            Assert.Equal(true, deleteCategory.IsDeleted);
        }
    }
}