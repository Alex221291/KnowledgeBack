using dsKnowledgeTest.Models;

namespace dsKnowledgeTest.Data.Init
{
    public static class FaqData
    {
        public static readonly Faq FaqForAuthorizations1 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Как зарегистрироваться на сайте?",
            Answer = "Для того, чтобы полноценно использовать наш сервис, " +
                     "необходимо пройти регистрацию, либо вход в систему, " +
                     "если у вас уже имеется учетная запись. " +
                     "В правом верхнем углу перейдите на страницу регистрации и следуйте указаниям. " +
                     "После успешной регистрации, пароль приходит на указанную почту.",
            Category = "ForAuthorizations"
        };

        public static readonly Faq FaqForAuthorizations2 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Как связаться с компанией, если клиент не нашел ответ в FAQ? " +
                       "Как можно связаться с поддержкой?",
            Answer = "В нижней части страницы нажмите на 'Контакты'," +
                     "в раскрывшемся окне заполните форму для обратной связи. Мы обязательно вам поможем.",
            Category = "ForAuthorizations"
        };

        public static readonly Faq FaqForAuthorizations3 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Не помню пароль? Что делать?",
            Answer = "В нижней части страницы нажмите на 'Контакты'," +
                     "в раскрывшемся окне заполните форму для обратной связи. Мы обязательно вам поможем.",
            Category = "ForAuthorizations"
        };

        public static readonly Faq FaqForAuthorizations4 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Не могу зайти в учетную запись?",
            Answer = "Проверьте email и пароль при вводе. Если не помогло, напишите в нам.",
            Category = "ForAuthorizations"
        };
        //=======================================================================
        public static readonly Faq FaqForStudents1 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Могу ли я сменить свои личные данные в профиле?",
            Answer = "Да. На странице профиля есть соответствующий раздел.",
            Category = "ForStudents"
        };
        public static readonly Faq FaqForStudents2 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Какой тест можно пройти?",
            Answer = "Любой тест доступен для прохождения.",
            Category = "ForStudents"
        };

        public static readonly Faq FaqForStudents3 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Какой тест можно пройти?",
            Answer = "После авторизации, все тесты доступны для прохождения.",
            Category = "ForStudents"
        };

        public static readonly Faq FaqForStudents4 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Как начать проходить тест?",
            Answer = "Прейдите в каталог тестов, выберите интересующую вас категорию, " +
                     "выберите тест из списка, нажмите 'Начать тест'.",
            Category = "ForStudents"
        };

        public static readonly Faq FaqForStudents5 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Закончилось время теста, что делать?",
            Answer = "После того как закончилось время и вы не успели его пройти, система даёт ответить вам на вопрос " +
                     "на котором выостановились и нажать кнопку 'Заверишть тест'.",
            Category = "ForStudents"
        };

        public static readonly Faq FaqForStudents6 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Как перейти к пропущенным вопросам?",
            Answer = "Если вы нажали 'Пропустить вопрос', то перейти к ним можно будет когда вы дойдёте до последнего вопроса в тесте, " +
                     "где появиться кнопка 'Перейти к пропущенным вопросам'.",
            Category = "ForStudents"
        };

        public static readonly Faq FaqForStudents7 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Где храниться история пройденных тестов?",
            Answer = "Перейдите в раздел профиля. На странице будет раздел 'История тестов'.",
            Category = "ForStudents"
        };

        public static readonly Faq FaqForStudents8 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Как посмотреть статистику пройденного теста ещё раз?",
            Answer = "Перейдите в раздел профиля. Нажмите вкладку 'Результаты тестов', " +
                     "найдите интересующий вас тест который вы проходили и нажмите кнопку 'перейти'.",
            Category = "ForStudents"
        };

        public static readonly Faq FaqForStudents9 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Что такое общий тест?",
            Answer = "При переходе в любую категорию тестов, будет карточка общего теста. " +
                     "В нём будут представлены все вопросы из тестов данной категории. " +
                     "Этот тест предназначен для тренировки ваших знаний и не хранится в вашей статистике.",
            Category = "ForStudents"
        };

        public static readonly Faq FaqForStudents10 = new()
        {
            Id = Guid.NewGuid(),
            Question = "Что такое экзаменационный тест?",
            Answer = "При переходе в любую категорию тестов, будет карточка экзаменационного теста. " +
                     "Тест формируется из вопросов тестов в данной категории," +
                     "у вас будет возможность выбора количества вопросов и минут." +
                     "Тест предназначен для проверки ваших знаний и хранится в статистике.",
            Category = "ForStudents"
        };

        public static readonly List<Faq> Faqs = new()
        {
            FaqForAuthorizations1, 
            FaqForAuthorizations2, 
            FaqForAuthorizations3, 
            FaqForAuthorizations4,

            FaqForStudents1, 
            FaqForStudents2,
            FaqForStudents3,
            FaqForStudents4,
            FaqForStudents5,
            FaqForStudents6,
            FaqForStudents7,
            FaqForStudents8,
            FaqForStudents9,
            FaqForStudents10,
        };
    }
}
