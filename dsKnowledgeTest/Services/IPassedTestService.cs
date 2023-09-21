using DocumentFormat.OpenXml.Spreadsheet;
using dsKnowledgeTest.Data;
using dsKnowledgeTest.Models;
using dsKnowledgeTest.ViewModels.AnsweredQuestionViewModels;
using dsKnowledgeTest.ViewModels.PassedTestViewModels;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Services
{
    public interface IPassedTestService
    {
        Task CreatePassedTestAsync(CreatePassedTestViewModel model);
        Task<List<PassedTestViewModel>> GetAllPassedTestsByUserIdAsync(string userId);
        Task<PassedTestViewModel?> GetByIdAsync(string passedTestId);

        Task<List<StatisticsPassedTestViewModel?>> GetStatisticsPassedTestsByUserIdAsync(string userId, int month,
            int year);
        Task<List<PassedTestAllUsersViewModel>> GetAllPassedTestsAsync();
    }

    public class PassedTestService : IPassedTestService
    {
        private readonly AppDbContext _db;
        private readonly IAnsweredQuestionService _answeredQuestionService;

        public PassedTestService(AppDbContext db, IAnsweredQuestionService answeredQuestionService)
        {
            _db = db;
            _answeredQuestionService = answeredQuestionService;
        }

        public async Task CreatePassedTestAsync(CreatePassedTestViewModel model)
        {
            var date = DateTime.UtcNow;
            await _db.PassedTests.AddAsync(new PassedTest
            {
                TimeSpent = model.TimeSpent,
                Status = model.Status,
                Score = model.Score,
                TestId = Guid.Parse(model.TestId),
                UserId = Guid.Parse(model.UserId),
                DateOfPassage = date
            });
            await _db.SaveChangesAsync();

            var passedTestId = (await _db.PassedTests
                .FirstOrDefaultAsync(t =>
                    t.TestId == Guid.Parse(model.TestId)
                    && t.UserId == Guid.Parse(model.UserId)
                    && t.DateOfPassage == date)).Id;
            foreach (var a in model.AnsweredQuestions)
            {
                await _answeredQuestionService.CreateAnsweredQuestionAsync(new CreateAnsweredQuestionViewModel
                {
                    Score = a.Score,
                    PassedTestsId = passedTestId.ToString(),
                    QuestionId = a.QuestionId,
                    ListSelectedAnswers = a.ListSelectedAnswers
                });
            }
        }

        public async  Task<List<PassedTestAllUsersViewModel>> GetAllPassedTestsAsync()
        {
            var passedTests = await _db.PassedTests
                .Include(p => p.Test)
                .ThenInclude(t => t!.Category)
                .Include(p => p.User)
                .Include(p => p.AnsweredQuestions)
                .Select(t => new PassedTestAllUsersViewModel
                {
                    Id = t.Id.ToString(),
                    FirstName = t.User!.FirstName,
                    SurName = t.User.SurName,
                    TimeSpent = t.TimeSpent,
                    Status = t.Status,
                    DateOfPassage = t.DateOfPassage.ToString(),
                    Score = t.Score,
                    TestName = t!.Test!.Name,
                    CntQuestion = t.Test.CntQuestion,
                    TestId = t.TestId.ToString(),
                    UserId = t.UserId.ToString(),
                    CategoryName = t!.Test!.Category!.Name,
                    AnsweredQuestions = t!.AnsweredQuestions!.Select(a =>
                        new AnsweredQuestionWithoutPassedTestIdViewModel
                        {
                            Id = a.Id.ToString(),
                            Score = a.Score,
                            QuestionId = a.QuestionId.ToString(),
                            ListSelectedAnswers = a.ListSelectedAnswers,
                            ListAnswers = a.Question!.ListAnswers,
                            ListTrueAnswers = a.Question.ListTrueAnswers,
                        }).ToList()
                }).ToListAsync();

            return passedTests;
        }

        public async Task<List<PassedTestViewModel>> GetAllPassedTestsByUserIdAsync(string userId)
        {
            var passedTests = await _db.PassedTests
                .Include("Test")
                .Include("AnsweredQuestions")
                .Where(p => p.UserId.ToString() == userId)
                .Select(t => new PassedTestViewModel
                {
                    Id = t.Id.ToString(),
                    TimeSpent = t.TimeSpent,
                    Status = t.Status,
                    DateOfPassage = t.DateOfPassage.ToString(),
                    Score = t.Score,
                    TestName = t.Test.Name,
                    CntQuestion = t.Test.CntQuestion,
                    TestId = t.TestId.ToString(),
                    UserId = t.UserId.ToString(),
                    AnsweredQuestions = t.AnsweredQuestions.Select(a =>
                        new AnsweredQuestionWithoutPassedTestIdViewModel
                        {
                            Id = a.Id.ToString(),
                            Score = a.Score,
                            QuestionId = a.QuestionId.ToString(),
                            ListSelectedAnswers = a.ListSelectedAnswers,
                            ListAnswers = a.Question.ListAnswers,
                            ListTrueAnswers = a.Question.ListTrueAnswers
                        }).ToList()
                }).ToListAsync();
            foreach (var t in passedTests)
            {
                t.CategoryName =
                    (await _db.Tests.Include("Category").FirstOrDefaultAsync(m => m.Id.ToString() == t.TestId)).Category
                    .Name;
            }

            return passedTests;
        }

        public async Task<PassedTestViewModel?> GetByIdAsync(string passedTestId)
        {
            var passedTest = await _db.PassedTests
                .Include("Test")
                .Include("AnsweredQuestions")
                .Select(t => new PassedTestViewModel
                {
                    Id = t.Id.ToString(),
                    TimeSpent = t.TimeSpent,
                    Status = t.Status,
                    DateOfPassage = t.DateOfPassage.ToString(),
                    Score = t.Score,
                    TestName = t.Test.Name,
                    CntQuestion = t.Test.CntQuestion,
                    TestId = t.TestId.ToString(),
                    UserId = t.UserId.ToString(),
                    AnsweredQuestions = t.AnsweredQuestions.Select(a =>
                        new AnsweredQuestionWithoutPassedTestIdViewModel
                        {
                            Id = a.Id.ToString(),
                            Score = a.Score,
                            QuestionId = a.QuestionId.ToString(),
                            ListSelectedAnswers = a.ListSelectedAnswers,
                            ListAnswers = a.Question.ListAnswers,
                            ListTrueAnswers = a.Question.ListTrueAnswers
                        }).ToList()
                })
                .FirstOrDefaultAsync(m => m.Id == passedTestId);

            passedTest.CategoryName =
                (await _db.Tests.Include("Category").FirstOrDefaultAsync(m => m.Id.ToString() == passedTest.TestId))
                .Category.Name;

            return passedTest;
        }

        public async Task<List<StatisticsPassedTestViewModel?>> GetStatisticsPassedTestsByUserIdAsync
            (string userId, int month, int year)
        {
            var statisticsPassedTest = new List<StatisticsPassedTestViewModel?>();
            if (month == 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    var scoresForMonth = await _db.PassedTests
                        .Where(p =>
                            p.UserId.ToString() == userId &&
                            p.DateOfPassage.Year == year &&
                            p.DateOfPassage.Month == i
                        )
                        .Select(t => t.Score)
                        .ToListAsync();

                    statisticsPassedTest.Add(new StatisticsPassedTestViewModel
                    {
                        CountPassedTest = scoresForMonth.Count,
                        AverageScore = scoresForMonth.Count == 0 ? 0 : scoresForMonth.Sum() / scoresForMonth.Count
                    });
                }
            }
            else
            {
                var startDate = new DateTime(year, month, 1);
                var endDateDay = startDate.AddMonths(1).AddDays(-1).Day;

                for (int i = 1; i <= endDateDay; i++)
                {
                    var scoresForDay = await _db.PassedTests
                        .Where(p =>
                            p.UserId.ToString() == userId &&
                            p.DateOfPassage.Year == year &&
                            p.DateOfPassage.Month == month &&
                            p.DateOfPassage.Day == i
                        )
                        .Select(t => t.Score)
                        .ToListAsync();
                    statisticsPassedTest.Add(new StatisticsPassedTestViewModel
                    {
                        CountPassedTest = scoresForDay.Count,
                        AverageScore = scoresForDay.Count == 0 ? 0 : scoresForDay.Sum() / scoresForDay.Count
                    });
                }
            }

            return statisticsPassedTest;
        }
    }
}