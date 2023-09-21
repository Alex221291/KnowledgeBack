using dsKnowledgeTest.Data;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Tests
{
    public static class ContextGenerator

    {
        public static AppDbContext Generate()
        {
            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            return new AppDbContext(optionBuilder.Options);
        }
    }
}