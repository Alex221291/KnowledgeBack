using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Data;
using dsKnowledgeTest.Models;
using dsKnowledgeTest.ViewModels.QuestionViewModels;
using Microsoft.EntityFrameworkCore;

namespace dsKnowledgeTest.Services;

public interface IQuestionService
{
    Task<List<QuestionViewModel>?> GetAllQuestionForTestAsync(Guid testId);

    Task<List<QuestionViewModel>?> GetAllQuestionForTestWithSortAsync(Guid testId, bool? isRandomQuestions,
        bool? isRandomAnswers);

    Task<QuestionViewModel?> GetQuestionByIdAsync(Guid questionId);
    Task CreateQuestionAsync(CreateQuestionViewModel question);
    Task EditQuestionAsync(EditQuestionViewModel question);
    Task DeleteQuestionAsync(Guid questionId);
}

public class QuestionService : IQuestionService
{
    private readonly AppDbContext _db;

    public QuestionService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<List<QuestionViewModel>?> GetAllQuestionForTestAsync(Guid testId)
    {
        var test = await _db.Tests.FirstOrDefaultAsync(t => t.Id == testId);
        return await GetAllQuestionForTestWithSortAsync(testId, test.IsRandomQuestions, test.IsRandomAnswers);
    }


    public async Task<List<QuestionViewModel>?> GetAllQuestionForTestWithSortAsync(Guid testId, bool? isRandomQuestions,
        bool? isRandomAnswers)
    {
        var questions = await _db.Questions.Where(q => q.IsDeleted == false)
            .Select(q => new QuestionViewModel
            {
                Id = q.Id.ToString(),
                Name = q.Name,
                QuestionType = q.QuestionType.ToString(),
                NumberOfPoints = q.NumberOfPoints,
                IconUrl = q.IconUrl,
                TestId = q.TestId.ToString(),
                Answers = isRandomAnswers == true ? GetRandomSortAnswers(q.ListAnswers) : q.ListAnswers,
                TrueAnswers = q.ListTrueAnswers
            }).Where(x => x.TestId == testId.ToString()).ToListAsync();

        return isRandomQuestions == true ? GetRandomSortQuestions(questions) : questions;
    }

    public async Task<QuestionViewModel?> GetQuestionByIdAsync(Guid questionId)
    {
        return await _db.Questions
            .Select(q => new QuestionViewModel
            {
                Id = q.Id.ToString(),
                Name = q.Name,
                QuestionType = q.QuestionType.ToString(),
                NumberOfPoints = q.NumberOfPoints,
                IconUrl = q.IconUrl,
                TestId = q.TestId.ToString(),
                Answers = q.ListAnswers,
                TrueAnswers = q.ListTrueAnswers
            })
            .FirstOrDefaultAsync(x => x.Id == questionId.ToString());
    }

    public async Task CreateQuestionAsync(CreateQuestionViewModel question)
    {
        for (int i = 0; i < question.TrueAnswers.Count; i++)
            question.TrueAnswers[i] ??= "";
        for (int i = 0; i < question.Answers.Count; i++)
            question.Answers[i] ??= "";
        await _db.Questions.AddAsync(new Question
        {
            Name = question.Name,
            QuestionType = (QuestionType)Enum.Parse(typeof(QuestionType), question.QuestionType),
            NumberOfPoints = question.NumberOfPoints,
            IconUrl = question.IconUrl,
            TestId = Guid.Parse(question.TestId),
            ListAnswers = question.Answers,
            ListTrueAnswers = question.TrueAnswers,
            IsDeleted = false
        });
        await _db.SaveChangesAsync();
        var testQuestion = await _db.Tests.FirstOrDefaultAsync(x => x.Id.ToString() == question.TestId);
        if (testQuestion != null)
        {
            testQuestion.CntQuestion++;
        }

        await _db.SaveChangesAsync();
    }

    public async Task EditQuestionAsync(EditQuestionViewModel question)
    {
        question.TrueAnswers.RemoveAll(a => a == null);
        question.Answers.RemoveAll(a => a == null);
        var questionVm = await _db.Questions.FirstOrDefaultAsync(q => q.Id.ToString() == question.Id);
        if (questionVm != null)
        {
            questionVm.Name = question.Name ?? questionVm.Name;
            questionVm.QuestionType = (QuestionType)Enum.Parse(typeof(QuestionType), question.QuestionType);
            questionVm.NumberOfPoints = question.NumberOfPoints ?? questionVm.NumberOfPoints;
            questionVm.IconUrl = question.IconUrl ?? questionVm.IconUrl;
            questionVm.TestId = Guid.Parse(question.TestId);
            questionVm.ListAnswers = question.Answers ?? questionVm.ListAnswers;
            questionVm.ListTrueAnswers = question.TrueAnswers ?? questionVm.ListTrueAnswers;

            _db.Questions.Update(questionVm);
            await _db.SaveChangesAsync();
        }
    }

    public async Task DeleteQuestionAsync(Guid questionId)
    {
        var question = await _db.Questions.FirstOrDefaultAsync(questionItem => questionItem.Id == questionId);
        if (question != null)
        {
            question.IsDeleted = true;
            _db.Questions.Update(question);

            var testQuestion = await _db.Tests.FirstOrDefaultAsync(x => x.Id == question.TestId);
            if (testQuestion != null)
            {
                testQuestion.CntQuestion--;
            }

            await _db.SaveChangesAsync();
        }
    }

    static List<string?>? GetRandomSortAnswers(List<string?>? l)
    {
        var list = l;
        if (list is { Count: > 1 })
        {
            var random = new Random();
            for (var i = 0; i < list.Count; i++)
            {
                var j = random.Next(list.Count);

                (list[j], list[i]) = (list[i], list[j]);
            }
        }

        return list;
    }

    static List<QuestionViewModel>? GetRandomSortQuestions(List<QuestionViewModel>? l)
    {
        var list = l;
        if (list is { Count: > 1 })
        {
            var random = new Random();
            for (var i = 0; i < list.Count; i++)
            {
                var j = random.Next(list.Count);

                (list[j], list[i]) = (list[i], list[j]);
            }
        }

        return list;
    }
}