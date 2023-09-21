using dsKnowledgeTest.Data;
using dsKnowledgeTest.Models;
using dsKnowledgeTest.ViewModels.AnsweredQuestionViewModels;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Services
{
    public interface IAnsweredQuestionService
    {
        Task CreateAnsweredQuestionAsync(CreateAnsweredQuestionViewModel model);
        Task<List<AnsweredQuestionWithoutPassedTestIdViewModel>> GetAllByPassedTestId(string passedTestId);
    }

    public class AnsweredQuestionService : IAnsweredQuestionService
    {
        private readonly AppDbContext _db;

        public AnsweredQuestionService(AppDbContext db)
        {
            _db = db;
        }

        public async Task CreateAnsweredQuestionAsync(CreateAnsweredQuestionViewModel model)
        {
            await _db.AnsweredQuestions.AddAsync(new AnsweredQuestion
            {
                ListSelectedAnswers = model.ListSelectedAnswers,
                Score = model.Score,
                PassedTestId = Guid.Parse(model.PassedTestsId),
                QuestionId = Guid.Parse(model.QuestionId)
            });
            await _db.SaveChangesAsync();
        }

        public async Task<List<AnsweredQuestionWithoutPassedTestIdViewModel>> GetAllByPassedTestId(string passedTestId)
        {
            return await _db.AnsweredQuestions
                .Where(a => a.PassedTestId.ToString() == passedTestId)
                .Select(m => new AnsweredQuestionWithoutPassedTestIdViewModel
                {
                    Id = m.Id.ToString(),
                    ListSelectedAnswers = m.ListSelectedAnswers,
                    Score = m.Score,
                    QuestionId = m.QuestionId.ToString()
                }).ToListAsync();
        }
    }
}