using dsKnowledgeTest.Data;
using dsKnowledgeTest.Services;

namespace dsKnowledgeTest.Tests
{
    public class FaqServiceTests
    {
        private readonly AppDbContext _context;
        public FaqServiceTests()
        {
            _context = ContextGenerator.Generate();
        }

        [Fact]
        public async Task GetAllAsync_AllTests()
        {
            await _context.AddRangeAsync(MockData.faqs);
            await _context.SaveChangesAsync();

            var faqService = new FaqService(_context);

            var result = await faqService.GetAllAsync();

            Assert.Equal(MockData.faqs.Count, result.Count);
        }
    }
}
