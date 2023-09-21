using dsKnowledgeTest.Data;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.FeedbackViewMdel;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Tests
{
    public class FeedbackServiceTests
    {
        private readonly AppDbContext _context;
        public FeedbackServiceTests()
        {
            _context = ContextGenerator.Generate();
        }

        [Fact]
        public async Task CreateAsync_AllTests()
        {
            var validModel = new CreateFeedbackViewModel
            {
                Email = "",
                FirstName = "",
                Subject = "",
                SurName = "",
                Description = ""
            };

            var feedbackService = new FeedbackService(_context);

            var countAfter = (await _context.Feedbacks.ToListAsync()).Count;

            var result = await feedbackService.CreateAsync(validModel);

            var countBefore = (await _context.Feedbacks.ToListAsync()).Count;

            Assert.Equal(validModel, result);
            Assert.NotEqual(countAfter, countBefore);
        }
    }
}
