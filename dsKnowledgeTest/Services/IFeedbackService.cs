using dsKnowledgeTest.Data;
using dsKnowledgeTest.Models;
using dsKnowledgeTest.ViewModels.FeedbackViewMdel;

namespace dsKnowledgeTest.Services
{
    public interface IFeedbackService
    {
        public Task<CreateFeedbackViewModel?> CreateAsync(CreateFeedbackViewModel model);
    }

    public class FeedbackService : IFeedbackService
    {
        private readonly AppDbContext _db;

        public FeedbackService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<CreateFeedbackViewModel?> CreateAsync(CreateFeedbackViewModel model)
        {
            try
            {
                await _db.Feedbacks.AddAsync(new Feedback
                {
                    FirstName = model.FirstName,
                    SurName = model.SurName,
                    Email = model.Email,
                    Subject = model.Subject,
                    Description = model.Description,
                    CreateData = DateTime.UtcNow,
                });
                await _db.SaveChangesAsync();
                return model;
            }
            catch
            {
                return null;
            }
        }
    }
}
