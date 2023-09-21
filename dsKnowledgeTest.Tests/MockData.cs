using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Models;

namespace dsKnowledgeTest.Tests
{
    public static class MockData
    {
        // Users data
        public static User lukanev = new()
        {
            Id = Guid.NewGuid(),
            Email = "lukanevam@gmail.com",
            Password = "25D55AD283AA400AF464C76D713C07AD",
            DataCreated = DateTime.Now,
            DataUpdated = DateTime.Now,
            Role = RolesConst.User,
            IsActivated = true,
            IsDeleted = false
        };

        public static User shtukar = new()
        {
            Id = Guid.NewGuid(),
            Email = "shtukar@gmail.com",
            Password = "25D55AD283AA400AF464C76D713C07AD",
            DataCreated = DateTime.Now,
            DataUpdated = DateTime.Now,
            Role = RolesConst.User,
            IsActivated = true,
            IsDeleted = true
        };

        public static User pechen = new()
        {
            Id = Guid.NewGuid(),
            Email = "pechen@gmail.com",
            Password = "25D55AD283AA400AF464C76D713C07AD",
            DataCreated = DateTime.Now,
            DataUpdated = DateTime.Now,
            Role = RolesConst.User,
            IsActivated = true,
            IsDeleted = false
        };

        public static List<User> users = new() { lukanev, shtukar, pechen };

        //Faq data
        public static Faq faq1 = new Faq
        {
            Id = Guid.NewGuid(),
            Question = "",
            Answer = "",
            Category = "ForTeachers"
        };

        public static Faq faq2 = new Faq
        {
            Id = Guid.NewGuid(),
            Question = "",
            Answer = "",
            Category = "ForAuthorizations"
        };

        public static Faq faq3 = new Faq
        {
            Id = Guid.NewGuid(),
            Question = "",
            Answer = "",
            Category = "ForStudents"
        };

        public static List<Faq> faqs = new List<Faq>
        {
            faq1, faq2, faq3
        };

        //Categories data
        public static Category category1 = new Category
        {
            Id = Guid.NewGuid(),
            Name = "Основы C#",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            IsDeleted = false,
        };

        public static Category category2 = new Category
        {
            Id = Guid.NewGuid(),
            Name = "Основы JS",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            IsDeleted = true,
        };

        public static Category category3 = new Category
        {
            Id = Guid.NewGuid(),
            Name = "Основы TS",
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            IsDeleted = false,
        };

        public static List<Category> categories = new()
        {
            category1, category2, category3
        };

        //Tests data
        public static Test test1 = new Test
        {
            Id = Guid.NewGuid(),
            Name = "Типы данных C#",
            IsDeleted = false,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            CategoryId = category1.Id,
        };

        public static Test test2 = new Test
        {
            Id = Guid.NewGuid(),
            Name = "Типы данных JS",
            IsDeleted = true,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            CategoryId = category2.Id,
        };

        public static Test test3 = new Test
        {
            Id = Guid.NewGuid(),
            Name = "Типы данных TS",
            IsDeleted = false,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now,
            CategoryId = category3.Id,
        };

        public static List<Test> tests = new() { test1, test2, test3 };

        //Questions data
        public static Question question1 = new Question
        {
            Id = Guid.NewGuid(),
            Name = "Какая разрядность типа int?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            ListAnswers = new() { "8", "16", "32" },
            ListTrueAnswers = new() { "32" },
            TestId = test1.Id,
            IsDeleted = false,
        };

        public static Question question2 = new Question
        {
            Id = Guid.NewGuid(),
            Name = "Какая разрядность типа byte?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            ListAnswers = new() { "8", "16", "32" },
            ListTrueAnswers = new() { "8" },
            TestId = test1.Id,
            IsDeleted = true,
        };

        public static Question question3 = new Question
        {
            Id = Guid.NewGuid(),
            Name = "Какая разрядность типа double?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            ListAnswers = new() { "64", "16", "32" },
            ListTrueAnswers = new() { "64" },
            TestId = test1.Id,
            IsDeleted = false,
        };

        public static List<Question> questions = new()
        {
            question1, question2, question3
        };

        
        //PassedTests data
        public static PassedTest passedTest1 = new()
        {
            Id = Guid.Parse("5768508a-8dd5-4349-9e4e-89ec9411c26f"),
            DateOfPassage = DateTime.Now,
            UserId = lukanev.Id,
            TestId = test1.Id,
            AnsweredQuestions = new()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Score = 10,
                    PassedTestId = Guid.Parse("5768508a-8dd5-4349-9e4e-89ec9411c26f"),
                    QuestionId = question1.Id,
                    ListSelectedAnswers = new() { "32" }
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Score = 10,
                    PassedTestId = Guid.Parse("5768508a-8dd5-4349-9e4e-89ec9411c26f"),
                    QuestionId = question2.Id,
                    ListSelectedAnswers = new() { "8" }
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Score = 0,
                    PassedTestId = Guid.Parse("5768508a-8dd5-4349-9e4e-89ec9411c26f"),
                    QuestionId = question3.Id,
                    ListSelectedAnswers = new() { "16" }
                }
            }
        };

        public static PassedTest passedTest2 = new()
        {
            Id = Guid.Parse("ea815715-0aeb-409f-9285-c9e5d4e7839d"),
            DateOfPassage = DateTime.Now,
            UserId = lukanev.Id,
            TestId = test1.Id,
            AnsweredQuestions = new()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Score = 10,
                    PassedTestId = Guid.Parse("ea815715-0aeb-409f-9285-c9e5d4e7839d"),
                    QuestionId = question1.Id,
                    ListSelectedAnswers = new() { "32" }
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Score = 10,
                    PassedTestId = Guid.Parse("ea815715-0aeb-409f-9285-c9e5d4e7839d"),
                    QuestionId = question2.Id,
                    ListSelectedAnswers = new() { "8" }
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Score = 0,
                    PassedTestId = passedTest1.Id,
                    QuestionId = Guid.Parse("ea815715-0aeb-409f-9285-c9e5d4e7839d"),
                    ListSelectedAnswers = new() { "16" }
                }
            }
        };

        public static PassedTest passedTest3 = new()
        {
            Id = Guid.Parse("f09708d5-d5eb-4cec-b85f-24e2a7dc6b77"),
            DateOfPassage = DateTime.Now,
            UserId = shtukar.Id,
            TestId = test1.Id,
            AnsweredQuestions = new()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Score = 10,
                    PassedTestId = Guid.Parse("f09708d5-d5eb-4cec-b85f-24e2a7dc6b77"),
                    QuestionId = question1.Id,
                    ListSelectedAnswers = new() { "32" }
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Score = 10,
                    PassedTestId = Guid.Parse("f09708d5-d5eb-4cec-b85f-24e2a7dc6b77"),
                    QuestionId = question2.Id,
                    ListSelectedAnswers = new() { "8" }
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Score = 0,
                    PassedTestId = Guid.Parse("f09708d5-d5eb-4cec-b85f-24e2a7dc6b77"),
                    QuestionId = question3.Id,
                    ListSelectedAnswers = new() { "16" }
                }
            }
        };

        public static List<PassedTest> passedtests = new()
        {
            passedTest1, passedTest2, passedTest3 

        };

        //AnsweredQuestions data
        public static AnsweredQuestion answeredQuestion1 = new()
        {
            Id = Guid.NewGuid(),
            Score = 10,
            PassedTestId = passedTest1.Id,
            QuestionId = question1.Id,
            ListSelectedAnswers = new() { "32" }
        };

        public static AnsweredQuestion answeredQuestion2 = new()
        {
            Id = Guid.NewGuid(),
            Score = 10,
            PassedTestId = passedTest1.Id,
            QuestionId = question2.Id,
            ListSelectedAnswers = new() { "8" }
        };

        public static AnsweredQuestion answeredQuestion3 = new()
        {
            Id = Guid.NewGuid(),
            Score = 0,
            PassedTestId = passedTest1.Id,
            QuestionId = question3.Id,
            ListSelectedAnswers = new() { "16" }
        };

        public static List<AnsweredQuestion> answeredQuestions = new()
        {
            answeredQuestion1, answeredQuestion2, answeredQuestion3
        };

    }
}