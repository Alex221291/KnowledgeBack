using dsKnowledgeTest.Data;
using ExcelDataReader;
using dsKnowledgeTest.Constants;
using dsKnowledgeTest.ViewModels.QuestionViewModels;
using dsKnowledgeTest.ViewModels.TestViewModels;
using Microsoft.EntityFrameworkCore;
namespace dsKnowledgeTest.Services;

public interface IExcelParserService
{
    public Task<object> ParseExcelToTest(IFormFile file);
}

public class ExcelParserService : IExcelParserService
{
    private readonly AppDbContext _db;

    public ExcelParserService(AppDbContext db)
    {
        _db = db;
    }

    public async Task<object> ParseExcelToTest(IFormFile file)
    {
        var excelTest = new CreateTestWithQuestionsViewModel();
        try
        {
            var fileExtension = Path.GetExtension(file.FileName);
            if (fileExtension != ".xlsx" && fileExtension != ".xls") return "Неверное расширение файла! Допустимые: xlsx, xls.";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);
            stream.Position = 0;
            using var reader = ExcelReaderFactory.CreateReader(stream);

            reader.Read();
            if (reader.GetValue(1) == null) return "Незаполнено название категории!";

            var categoryName = reader.GetValue(1).ToString();
            var category = await _db.Categories.FirstOrDefaultAsync(c => c.Name == categoryName);
            if (category == null) return "Такой категории нет!";
            excelTest.CategoryId = category.Id.ToString();

            reader.Read();
            if (reader.GetValue(1) == null) return "Незаполнено название теста!";
            var excelTestName = reader.GetValue(1).ToString();
            var test = await _db.Tests.FirstOrDefaultAsync(t => t.CategoryId == category.Id && t.Name == excelTestName);
            if (test != null) return "Тест с таким именем уже существует в категории!";
            excelTest.Name = reader.GetValue(1).ToString();

            reader.Read();
            if (reader.GetValue(1) == null) return "Незаполнено описание!";
            excelTest.Description = reader.GetValue(1).ToString();

            reader.Read();
            if (reader.GetValue(1) == null) return "Незаполнен уровень тетса!";
            var testLevelString = reader.GetValue(1).ToString().ToLower();
            switch (testLevelString.ToLower())
            {
                case "подготовительный":
                    excelTest.TestLevel = TestLevel.Preparatory.ToString();
                    break;
                case "базовый":
                    excelTest.TestLevel = TestLevel.Middle.ToString();
                    break;
                case "высокий":
                    excelTest.TestLevel = TestLevel.High.ToString();
                    break;
                default: return "Некорректный уровень теста: " + testLevelString;
            }

            reader.Read();
            if (reader.GetValue(1) == null) return "Незаполнено время!";
            var timeString = reader.GetValue(1).ToString();
            if (int.TryParse(timeString, out var time) && time >= 0)
            {
                excelTest.TimeForTest = time;
                excelTest.IsTestOnTime = time > 0;
            }
            else
            {
                return "Некорректное время: " + timeString;
            }

            /*reader.Read();
            if (reader.GetValue(1) == null) return "Незаполнено количество баллов за тест!";
            var scoreString = reader.GetValue(1).ToString();
            if (int.TryParse(scoreString, out var score) && score > 0)
            {
                excelTest.Score = score;
            }
            else
            {
                return "Некорректное количество баллов: " + scoreString;
            }*/

            reader.Read();
            if (reader.GetValue(1) == null) return "Незаполнен пороговый балл!";
            var minThresholdString = reader.GetValue(1).ToString();
            if (double.TryParse(minThresholdString, out var minT))
            {
                excelTest.MinThreshold = minT;
            }
            else
            {
                return "Некорректный пороговый балл: " + minThresholdString;
            }


            reader.Read();
            if (reader.GetValue(1) == null) return "Незаполнен произвольный порядок вопросов!";
            var isRandomQuestionsString = reader.GetValue(1).ToString();
            switch (isRandomQuestionsString)
            {
                case "да":
                    excelTest.IsRandomQuestions = true;
                    break;
                case "нет":
                    excelTest.IsRandomQuestions = false;
                    break;
                default:
                    return "Некорректная сортировка вопросов: " + isRandomQuestionsString;
            }


            reader.Read();
            if (reader.GetValue(1) == null) return "Незаполнен произвольный порядок ответов!";
            var isRandomAnswersString = reader.GetValue(1).ToString();
            switch (isRandomAnswersString)
            {
                case "да":
                    excelTest.IsRandomAnswers = true;
                    break;
                case "нет":
                    excelTest.IsRandomAnswers = false;
                    break;
                default:
                    return "Некорректная сортировка ответов: " + isRandomAnswersString;
            }

            reader.Read();

            excelTest.Questions = new List<CreateQuestionWithoutTestIdViewModel>();
            while (reader.Read() && reader.GetValue(1) != null && reader.GetValue(4) != null && reader.GetValue(5) != null)
            {
                var question = new CreateQuestionWithoutTestIdViewModel();

                if (reader.GetValue(0) == null) return "Незаполнены номера вопросов!";
                var questionNumberString = reader.GetValue(0).ToString();
                if (int.TryParse(questionNumberString, out var questionNumber) && questionNumber > 0)
                {
                    question.NumberOfPoints = questionNumber;
                }
                else
                {
                    return "Некорректные номера вопросов!";
                }

                if (reader.GetValue(1) == null) return "Вопрос N" + questionNumber + ". Незаполнен вопрос!";
                question.Name = reader.GetValue(1).ToString();


                if (reader.GetValue(2) == null)
                    return "Вопрос N" + reader.GetValue(0) + ". Незаполнено количество баллов за вопрос!";
                var scoreForQuestionString = reader.GetValue(2).ToString();
                if (int.TryParse(scoreForQuestionString, out var scoreForQuestion) && scoreForQuestion > 0)
                {
                    question.NumberOfPoints = scoreForQuestion;
                }
                else
                {
                    return "Вопрос N" + questionNumber + ". Некорректный балл: " + scoreForQuestionString;
                }

                if (reader.GetValue(3) == null) return "Вопрос N" + questionNumber + ". Незаполнен тип вопроса!";
                var questionTypeString = reader.GetValue(3).ToString().ToLower();
                switch (questionTypeString)
                {
                    case "один вариант":
                        question.QuestionType = QuestionType.OneOfMany.ToString();
                        break;
                    case "несколько вариантов":
                        question.QuestionType = QuestionType.ManyOfMany.ToString();
                        break;
                    case "текстовый":
                        question.QuestionType = QuestionType.InputText.ToString();
                        break;
                    default:
                        return "Вопрос N" + questionNumber + ". Некорректный тип вопроса: " + questionTypeString;
                }

                if (reader.GetValue(4) == null) return "Вопрос N" + questionNumber + ". Незаполнены ответы!";
                question.Answers = reader.GetValue(4).ToString().Replace("○ ", "○").Split("○").ToList();
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    question.Answers[i] = question.Answers[i].Trim();
                }

                if (reader.GetValue(5) == null)
                    return "Вопрос N" + questionNumber + ". Незаполнены правильные ответы!";
                question.TrueAnswers = reader.GetValue(5).ToString().Replace("○ ", "○").Split("○").ToList();
                for (int i = 0; i < question.TrueAnswers.Count; i++)
                {
                    question.Answers[i] = question.TrueAnswers[i].Trim();
                }

                excelTest.Questions.Add(question);
            }

            excelTest.Score = excelTest.Questions.Sum(q => q.NumberOfPoints);

            return excelTest;
        }
        catch
        {
            return "Пустой файл!";
        }
    }
}