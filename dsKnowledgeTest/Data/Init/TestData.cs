using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Models;

namespace dsKnowledgeTest.Data.Init
{
    public static class TestData
    {
        public static readonly Test BasicsCSharpTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы C#",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему C#. " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 10,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.CSharpCategory.Id,
        };

        public static readonly Test BasicsJavaScriptTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы JavaScript",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему JavaScrypt. " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 10,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.JavaScriptCategory.Id,
        };
        public static readonly Test BasicsAlgorithmizationTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы алгоритмизации и программирования",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему Алгоритмизации. " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 10,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.AlgorithmizationCategory.Id,
        };

        public static readonly Test BasicsBusinessAnalysisTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы бизнес анализа",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему Бизнес анализа. " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 5,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.BusinessAnalysisCategory.Id,
        };

        public static readonly Test BasicsTestingTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы Тестирования",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему тестирования. " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 5,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.TestingCategory.Id,
        };

        public static readonly Test BasicsJavaTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы Java",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему Java. " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 5,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.JavaCategory.Id,
        };

        public static readonly Test BasicsKotlinTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы Kotlin",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему Kotlin " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 5,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.KotlinCategory.Id,
        };

        public static readonly Test BasicsHtmlTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы HTML",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему HTML " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 5,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.HtmlCategory.Id,
        };

        public static readonly Test BasicsCssTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы CSS",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему CSS. " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 5,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.CssCategory.Id,
        };

        public static readonly Test BasicsPythonTest = new()
        {
            Id = Guid.NewGuid(),
            Name = "Основы Python",
            Description = "Здесь вы можете пройти тест с уровнем «Начальный» на тему Python. " +
                          "На тест выделяется небольшой промежуток времени, " +
                          "также после окончания теста вы сможете просмотреть результаты и " +
                          "ознакомиться с верными и неверными ответами.",
            ImageUrl = null,
            TestLevel = TestLevel.Preparatory,
            IsTestOnTime = true,
            TimeForTest = 10,
            CntQuestion = 5,
            Score = 100,
            IsDeleted = false,
            IsRandomAnswers = true,
            IsRandomQuestions = true,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            CategoryId = CategoryData.PythonCategory.Id,
        };

        public static readonly List<Test> Tests = new()
        {
            BasicsCSharpTest, 
            BasicsJavaScriptTest, 
            BasicsAlgorithmizationTest,
            BasicsBusinessAnalysisTest,
            BasicsKotlinTest,
            BasicsJavaTest,
            BasicsHtmlTest,
            BasicsCssTest,
            BasicsTestingTest,
            BasicsPythonTest,
        };
    }
}
