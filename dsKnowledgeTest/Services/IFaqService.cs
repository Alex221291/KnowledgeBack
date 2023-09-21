using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Data;
using dsKnowledgeTest.ViewModels.FaqViewModel;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Services
{
    public interface IFaqService
    {
        public Task<List<FaqViewModel>> GetAllAsync();
        public Task<List<FaqViewModel>> GetFaqForAuthorizationsAsync();
        public Task<List<FaqViewModel>> GetFaqForStudentsAsync();
        public Task<List<FaqViewModel>> GetFaqForTeachersAsync();
    }

    public class FaqService : IFaqService
    {
        private readonly AppDbContext _db;

        public FaqService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<FaqViewModel>> GetAllAsync()
        {
            return await _db.Faq.AsNoTracking()
                .Select(f => new FaqViewModel()
                {
                    Id = f.Id,
                    Question = f.Question,
                    Answer = f.Answer,
                    Category = f.Category
                })
                .ToListAsync();
        }

        public async Task<List<FaqViewModel>> GetFaqForAuthorizationsAsync()
        {
            return await _db.Faq.AsNoTracking()
                .Select(f => new FaqViewModel()
                {
                    Id = f.Id,
                    Question = f.Question,
                    Answer = f.Answer,
                    Category = f.Category
                })
                .Where(f
                    => f.Category == FaqCategoryConst.ForAuthorizations.ToString())
                .ToListAsync();
        }

        public async Task<List<FaqViewModel>> GetFaqForStudentsAsync()
        {
            return await _db.Faq.AsNoTracking()
                .Select(f => new FaqViewModel()
                {
                    Id = f.Id,
                    Question = f.Question,
                    Answer = f.Answer,
                    Category = f.Category
                })
                .Where(f
                    => f.Category == FaqCategoryConst.ForStudents.ToString())
                .ToListAsync();
        }

        public async Task<List<FaqViewModel>> GetFaqForTeachersAsync()
        {
            return await _db.Faq.AsNoTracking()
                .Select(f => new FaqViewModel()
                {
                    Id = f.Id,
                    Question = f.Question,
                    Answer = f.Answer,
                    Category = f.Category
                })
                .Where(f
                    => f.Category == FaqCategoryConst.ForTeachers.ToString())
                .ToListAsync();
        }
    }
}
