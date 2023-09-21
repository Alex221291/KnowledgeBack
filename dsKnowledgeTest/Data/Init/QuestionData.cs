using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Models;

namespace dsKnowledgeTest.Data.Init
{
    public static class QuestionData
    {
        public static readonly Question QuestionForBasicsCSharpTest1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какие типы переменных существуют?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new() { 
                "int, char, bool, string", 
                "int, char, bool, float, double",
                "int, char, bool, float, double, uint, short",
                "Все перечисленные"
            },
            ListTrueAnswers = new() { "Все перечисленные" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCSharpTest2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где правильно создан массив?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new() {
                "int arr[] = {2, 5};",
                "int arr = [2, 5];",
                "int[] arr = new Array [2, 5];",
                "int[] arr = new int [2] {2, 5};"
            },
            ListTrueAnswers = new() { "int[] arr = new int [2] {2, 5};" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCSharpTest3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какой объём памяти выделяется под тип int?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new() { "8", "16", "32", "64" },
            ListTrueAnswers = new() { "32" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCSharpTest4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где правильно создана переменная?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "x = 0;", 
                "$x = 10;", 
                "int num = '1';", 
                "char symbol = 'A';"
            },
            ListTrueAnswers = new() { "char symbol = 'A';" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCSharpTest5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какая функция корректно сравнивает две подстроки?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "String.Check(\"hi\", \"hello\");",
                "String.Equal(\"hi\", \"hello\");",
                "String.Match(\"hi\", \"hello\");",
                "String.Compare(\"hi\", \"hello\");"
            },
            ListTrueAnswers = new() { "String.Compare(\"hi\", \"hello\");" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCSharpTest6 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Что делает try-catch?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "Работает с файлами",
                "Работает с базой данных",
                "Работает с классами",
                "Работает с исключениями"
            },
            ListTrueAnswers = new() { "Работает с исключениями" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCSharpTest7 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где верно происходит вывод данных в консоль?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "Console.write(\"Hi\");",
                "сonsole.log(\"Hi\");",
                "print(\"Hi\");",
                "Console.WriteLine(\"Hi\");"
            },
            ListTrueAnswers = new() { "Console.WriteLine(\"Hi\");" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCSharpTest8 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Для чего можно использовать язык C#?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "Для создания веб сайтов",
                "Для создания программ под ПК",
                "Для написания игр",
                "Всё перечисленное"

            },
            ListTrueAnswers = new() { "Всё перечисленное" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCSharpTest9 = new()
        {
            Id = Guid.NewGuid(),
            Name = "В чем отличие между break и continue?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "Нет отличий",
                "Continue работает только в циклах, break дополнительно в методах",
                "Break используется в Switch case, а continue в циклах",
                "Continue пропускает итерацию, break выходит из цикла"
            },
            ListTrueAnswers = new() { "32" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCSharpTest10 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какие циклы существуют в языке C#?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "for",
                "for, while",
                "for, while, do while",
                "for, while, do while, foreach"
            },
            ListTrueAnswers = new() { "for, while, do while, foreach" },
            TestId = TestData.BasicsCSharpTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsCSharpTest = new()
        {
            QuestionForBasicsCSharpTest1,
            QuestionForBasicsCSharpTest2,
            QuestionForBasicsCSharpTest3,
            QuestionForBasicsCSharpTest4,
            QuestionForBasicsCSharpTest5,
            QuestionForBasicsCSharpTest6,
            QuestionForBasicsCSharpTest7,
            QuestionForBasicsCSharpTest8,
            QuestionForBasicsCSharpTest9,
            QuestionForBasicsCSharpTest10,
        };

        public static readonly Question QuestionForBasicsJavaScript1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "В чем отличие между локальной и глобальной переменной?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "Отличий нет",
                "Локальные видны повсюду, глобальные только в функциях",
                "Локальные можно переопределять, глобальные нельзя",
                "Глобальные видны повсюду, локальные только в функциях"
            },
            ListTrueAnswers = new() { "Глобальные видны повсюду, локальные только в функциях" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJavaScript2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "В чем разница между confirm и prompt?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "Они ничем не отличаются",
                "confirm вызывает диалоговое окно с полем для ввода, prompt - окно с подтверждением",
                "prompt вызывает диалоговое окно об обшибке, confirm - окно с подтверждением",
                "prompt вызывает диалоговое окно с полем для ввода, confirm - окно с подтверждением"
            },
            ListTrueAnswers = new() { "prompt вызывает диалоговое окно с полем для ввода, confirm - окно с подтверждением" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJavaScript3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какие значения можно хранить в переменных?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "Только числа и строки",
                "Строки, числа с точкой и простые числа",
                "Строки и символы",
                "Строки, числа с точкой, простые числа и булевые выражения"
            },
            ListTrueAnswers = new() { "Строки, числа с точкой, простые числа и булевые выражения" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJavaScript4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какие циклы есть в языке JavaScript?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "for, forMap, foreach, while",
                "for, forMap, foreach, while, do while",
                "for, while, do while, foreach",
                "for, while, do while"
            },
            ListTrueAnswers = new() { "for, while, do while" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJavaScript5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где верно указано имя переменной?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "var 2num;",
                "ver num;",
                "var num-1;",
                "var num_1;"
            },
            ListTrueAnswers = new() { "var num_1;" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJavaScript6 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какая переменная записана неверно?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "var num = \"STRING\";",
                "var isDone = 0;",
                "var b = false;",
                "var number = 12,5;"
            },
            ListTrueAnswers = new() { "var number = 12,5;" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJavaScript7 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где можно использовать JavaScript?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "Мобильные приложения",
                "Веб-приложения",
                "Серверные приложения",
                "Можно во всех перечисленных"
            },
            ListTrueAnswers = new() { "Можно во всех перечисленных" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJavaScript8 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где верно указан вывод данных?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "documentWrite(\"Hello\");",
                "print(Hello);",
                "prompt(\"Hello\")",
                "console.log(\"Hello\");"
            },
            ListTrueAnswers = new() { "console.log(\"Hello\");" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJavaScript9 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где верно указан запуск всплывающего окна?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "new alert (\"Hi\")",
                "info (\"Hi\")",
                "Нет верных вариантов",
                "alert (\"Hi\")"
            },
            ListTrueAnswers = new() { "alert (\"Hi\")" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJavaScript10 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Что такое условный оператор?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "Конструкция, что выполняет код несколько раз",
                "Конструкция для создания определенной переменной",
                "Конструкция для работы с исключениями",
                "Оператор сравнения значений"
            },
            ListTrueAnswers = new() { "Оператор сравнения значений" },
            TestId = TestData.BasicsJavaScriptTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsJavaScriptTest = new()
        {
            QuestionForBasicsJavaScript1,
            QuestionForBasicsJavaScript2,
            QuestionForBasicsJavaScript3,
            QuestionForBasicsJavaScript4,
            QuestionForBasicsJavaScript5,
            QuestionForBasicsJavaScript6,
            QuestionForBasicsJavaScript7,
            QuestionForBasicsJavaScript8,
            QuestionForBasicsJavaScript9,
            QuestionForBasicsJavaScript10,
        };

        public static readonly Question QuestionForBasicsAlgorithmization1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Геометрическая фигура ромб используется в блок-схемах для обозначения:",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "принятия решения",
                "начала или конца алгоритма",
                "ввода или вывода",
            },
            ListTrueAnswers = new() { "принятия решения" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsAlgorithmization2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Геометрическая фигура прямоугольник используется в блок-схемах для обозначения:",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "принятия решения",
                "выполнения действия",
                "ввода или вывода",
            },
            ListTrueAnswers = new() { "выполнения действия" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsAlgorithmization3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Алгоритм называется линейным, если:",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "ход его выполнения зависит от истинности тех или иных условий",
                "представлен в табличной форме",
                "его команды выполняются в порядке следования друг за другом",
            },
            ListTrueAnswers = new() { "его команды выполняются в порядке следования друг за другом" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsAlgorithmization4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Алгоритм - это",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "последовательность действий, которая приводит к решению задачи",
                "набор команд для компьютера",
                "ориентированный граф, указывающий порядок выполнения команд",
            },
            ListTrueAnswers = new() { "последовательность действий, которая приводит к решению задачи" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsAlgorithmization5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Наибольшей наглядностью обладают следующие формы записи алгоритмов:",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "рекурсивные",
                "словесные",
                "графические",
            },
            ListTrueAnswers = new() { "графические" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsAlgorithmization6 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Как называется свойство алгоритма, означающее, что данный алгоритм применим к решению целого класса задач:",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "определенность",
                "массовость",
                "понятность",
            },
            ListTrueAnswers = new() { "массовость" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsAlgorithmization7 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Алгоритм, в котором все действия выполняются последовательно друг за другом и только один раз:",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "одиночный алгоритм",
                "линейный алгоритм",
                "не повторяющийся алгоритм",
            },
            ListTrueAnswers = new() { "линейный алгоритм" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsAlgorithmization8 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Перевод программ с языка высокого уровня на язык более низкого уровня обеспечивает программа :",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "диструктор",
                "ассемблер",
                "компилятор",
            },
            ListTrueAnswers = new() { "компилятор" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsAlgorithmization9 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Символьный тип данных объявляется служебным словом:",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "STRING",
                "WORD",
                "CHAR",
            },
            ListTrueAnswers = new() { "CHAR" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsAlgorithmization10 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Логический тип данных объявляется служебным словом:",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 10,
            IconUrl = null,
            ListAnswers = new()
            {
                "BOOLEAN",
                "BYTE",
                "LOGIC",
            },
            ListTrueAnswers = new() { "BOOLEAN" },
            TestId = TestData.BasicsAlgorithmizationTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsAlgorithmizationTest = new()
        {
            QuestionForBasicsAlgorithmization1,
            QuestionForBasicsAlgorithmization2,
            QuestionForBasicsAlgorithmization3,
            QuestionForBasicsAlgorithmization4,
            QuestionForBasicsAlgorithmization5,
            QuestionForBasicsAlgorithmization6,
            QuestionForBasicsAlgorithmization7,
            QuestionForBasicsAlgorithmization8,
            QuestionForBasicsAlgorithmization9,
            QuestionForBasicsAlgorithmization10,
        };

        public static readonly Question QuestionForBasicsTesting1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какая разница между статическим и динамическим тестированием?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Статическое тестирование включает в себя модификацию программного кода.",
                "Статическое тестирование подразумевает подход, при котором \"тестирование\" проводится путем изучения и анализа программного кода без его запуска.",
                "Статическое тестирование подразумевает тестирование кода наперед созданным набором тестов.",
            },
            ListTrueAnswers = new() { "Статическое тестирование включает в себя модификацию программного кода." },
            TestId = TestData.BasicsTestingTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsTesting2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Количество тестов определяет качество покрытия тестами программного кода?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Да",
                "Нет",
            },
            ListTrueAnswers = new() { "Да" },
            TestId = TestData.BasicsTestingTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsTesting3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Что такое Big-Bang тестирование?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Тестирование, выполненное после сбоя системы",
                "Тестирование системы после преднамеренного вызова системного сбоя",
                "Подход к тестированию, при котором ставится цель обнаружить те ошибки, которые могут привести к полному краху системы",
            },
            ListTrueAnswers = new() { "Тестирование, выполненное после сбоя системы" },
            TestId = TestData.BasicsTestingTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsTesting4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Логирование на стороне сервера существенно влияет на производительность сервера в целом?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Нет, не влияет",
                "Да, влияет",
                "Влияет только в случае, если логируется много избыточной информации",
            },
            ListTrueAnswers = new() { "Да, влияет" },
            TestId = TestData.BasicsTestingTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsTesting5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Выберите верные утверждения относительно QA и QC:",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "QC не опирается на спецификацию",
                "QC выполняется разработчиками",
                "QA в отличии от QC носит более превентивный характер",
            },
            ListTrueAnswers = new() { "QA в отличии от QC носит более превентивный характер" },
            TestId = TestData.BasicsTestingTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsTestingTest = new()
        {
            QuestionForBasicsTesting1,
            QuestionForBasicsTesting2,
            QuestionForBasicsTesting3,
            QuestionForBasicsTesting4,
            QuestionForBasicsTesting5,
        };

        public static readonly Question QuestionForBasicsJava1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Для чего можно использовать Java?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Для создания сайтов",
                "Для создания программ под ПК",
                "Для создания игр",
                "Для всего перечисленного"
            },
            ListTrueAnswers = new() { "Для всего перечисленного" },
            TestId = TestData.BasicsJavaTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJava2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Сколько параметров может принимать функция?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Не более 3",
                "Не более 5",
                "Не более 10",
                "Неограниченное количество"
            },
            ListTrueAnswers = new() { "Неограниченное количество" },
            TestId = TestData.BasicsJavaTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJava3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где правильно создана простая переменная?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "byte x = 100000;",
                "char str = 'ab';",
                "bool isDone = true;",
                "float x = 23.3f;"
            },
            ListTrueAnswers = new() { "float x = 23.3f;" },
            TestId = TestData.BasicsJavaTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJava4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Каждый файл должен называется...",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "по имени основного метода в нем",
                "по имени названия пакета",
                "как вам захочется",
                "по имени класса в нём"
            },
            ListTrueAnswers = new() { "по имени класса в нём" },
            TestId = TestData.BasicsJavaTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsJava5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где правильно осуществлен вывод?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "System.print(\"Hello World!\");",
                "System.out(\"Hello World!\");",
                "System.out.print = \"Hello World!\";",
                "System.out.print(\"Hello World!\");"
            },
            ListTrueAnswers = new() { "System.out.print(\"Hello World!\");" },
            TestId = TestData.BasicsJavaTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsJavaTest = new()
        {
            QuestionForBasicsJava1,
            QuestionForBasicsJava2,
            QuestionForBasicsJava3,
            QuestionForBasicsJava4,
            QuestionForBasicsJava5,
        };

        public static readonly Question QuestionForBasicsKotlin1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какого типа данных не существует в Kotlin?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Int",
                "Array",
                "Все перечисленные типы данных существуют",
                "Object"
            },
            ListTrueAnswers = new() { "Все перечисленные типы данных существуют" },
            TestId = TestData.BasicsKotlinTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsKotlin2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где неверно создана переменная?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "var num = 50;",
                "var number: Float = 45.001f",
                "var isGet = null",
                "val str: String = null"
            },
            ListTrueAnswers = new() { "val str: String = null" },
            TestId = TestData.BasicsKotlinTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsKotlin3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "В чем отличие между var и val?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Отличий между ними нет",
                "val - позволяет установить и изменять значение, var - позволяет установить значение без изменения в дальнейшем",
                "val служит для создания массивов, var для создания переменных",
                "var - позволяет установить и изменять значение, val - позволяет установить значение без изменения в дальнейшем"
            },
            ListTrueAnswers = new() { "var - позволяет установить и изменять значение, val - позволяет установить значение без изменения в дальнейшем" },
            TestId = TestData.BasicsKotlinTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsKotlin4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Можно ли в файле Kotlin прописать код на Java?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Да, можно прописывать любой Java код",
                "Можно, но лишь некоторые классы и функции",
                "Нельзя. Kotlin вмещает множество схожих функций и классов что и в Java, но писать код на Java в Kotlin файле нельзя",
            },
            ListTrueAnswers = new() { "Нельзя. Kotlin вмещает множество схожих функций и классов что и в Java, но писать код на Java в Kotlin файле нельзя" },
            TestId = TestData.BasicsKotlinTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsKotlin5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какая функция служит для вывода данных?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "write()",
                "system.out()",
                "log()",
                "print()"
            },
            ListTrueAnswers = new() { "print()" },
            TestId = TestData.BasicsKotlinTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsKotlinTest = new()
        {
            QuestionForBasicsKotlin1,
            QuestionForBasicsKotlin2,
            QuestionForBasicsKotlin3,
            QuestionForBasicsKotlin4,
            QuestionForBasicsKotlin5,
        };

        public static readonly Question QuestionForBasicsPython1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какая библиотека отвечает за время?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "localtime",
                "clock",
                "time",
                "Time"
            },
            ListTrueAnswers = new() { "time" },
            TestId = TestData.BasicsPythonTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsPython2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какая функция выводит что-либо в консоль?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "write();",
                "log();",
                "out();",
                "print();"
            },
            ListTrueAnswers = new() { "print();" },
            TestId = TestData.BasicsPythonTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsPython3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Как получить данные от пользователя?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Использовать метод get()",
                "Использовать метод cin()",
                "Использовать метод readLine()",
                "Использовать метод input()"
            },
            ListTrueAnswers = new() { "Использовать метод input()" },
            TestId = TestData.BasicsPythonTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsPython4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Сколько библиотек можно импортировать в один проект?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Не более 3",
                "Не более 5",
                "Не более 10",
                "Неограниченное количество"
            },
            ListTrueAnswers = new() { "Неограниченное количество" },
            TestId = TestData.BasicsPythonTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsPython5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где правильно создана переменная?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "int num = 2",
                "var num = 2",
                "$num = 2",
                "num = float(2)"
            },
            ListTrueAnswers = new() { "num = float(2)" },
            TestId = TestData.BasicsPythonTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsPythonTest = new()
        {
            QuestionForBasicsPython1,
            QuestionForBasicsPython2,
            QuestionForBasicsPython3,
            QuestionForBasicsPython4,
            QuestionForBasicsPython5,
        };

        public static readonly Question QuestionForBasicsHtml1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Для чего используют тег div?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Для табличной верстки сайта",
                "Для работы с текстом",
                "Для создание таблиц",
                "Для блочной верстки сайта"
            },
            ListTrueAnswers = new() { "Для блочной верстки сайта" },
            TestId = TestData.BasicsHtmlTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsHtml2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какого поля input не существует?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "input type=\"color\"",
                "input type=\"date\"",
                "input type=\"number\"",
                "input type=\"name\""
            },
            ListTrueAnswers = new() { "input type=\"name\"" },
            TestId = TestData.BasicsHtmlTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsHtml3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какой тег делает текст курсивом?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "strong",
                "strike",
                "span",
                "em"
            },
            ListTrueAnswers = new() { "em" },
            TestId = TestData.BasicsHtmlTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsHtml4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какой тег выведет текст, если JavaScript будет выключен на сайте?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "nojs",
                "nojavascript",
                "nojava",
                "noscript"
            },
            ListTrueAnswers = new() { "noscript" },
            TestId = TestData.BasicsHtmlTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsHtml5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какой тег не используется при работе с таблицами?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Tr",
                "Td",
                "Th",
                "Tt"
            },
            ListTrueAnswers = new() { "Tt" },
            TestId = TestData.BasicsHtmlTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsHtmlTest = new()
        {
            QuestionForBasicsHtml1,
            QuestionForBasicsHtml2,
            QuestionForBasicsHtml3,
            QuestionForBasicsHtml4,
            QuestionForBasicsHtml5,
        };

        public static readonly Question QuestionForBasicsCss1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Как указать важность для свойства?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Такое сделать нет возможности",
                "Необходимое более важное значение записать последний в селекторе",
                "Указать перед свойством !",
                "После свойства прописать !important"
            },
            ListTrueAnswers = new() { "После свойства прописать !important" },
            TestId = TestData.BasicsCssTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCss2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Какое свойство указывает задний фон для тега?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "color",
                "background-clip",
                "display",
                "background"
            },
            ListTrueAnswers = new() { "background" },
            TestId = TestData.BasicsCssTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCss3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Что такое «outline»?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Внешняя обводка блока",
                "Установка границ для блока",
                "Установка тени блока",
                "Внешнее свечение блока"
            },
            ListTrueAnswers = new() { "Внешнее свечение блока" },
            TestId = TestData.BasicsCssTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCss4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Где неверно записано свойство «Font-family»?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "font-family: serif;",
                "font-family: \"Gill Sans\", sans-serif;",
                "font-family: Georgia, serif;",
                "Все варианты являются верными"
            },
            ListTrueAnswers = new() { "Все варианты являются верными" },
            TestId = TestData.BasicsCssTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsCss5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Как установить ширину объекта?",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "При помощи атрибута width",
                "За счёт свойства width",
                "Оба способа подходят для этого",
            },
            ListTrueAnswers = new() { "Оба способа подходят для этого" },
            TestId = TestData.BasicsCssTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsCssTest = new()
        {
            QuestionForBasicsCss1,
            QuestionForBasicsCss2,
            QuestionForBasicsCss3,
            QuestionForBasicsCss4,
            QuestionForBasicsCss5,
        };

        public static readonly Question QuestionForBasicsBusinessAnalysis1 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Описать структуру системы бизнес-процессов, показать состав процессов одного уровня " +
                   "абстракции и взаимосвязи между ними можно с помощью диаграммы в нотации",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "EPC",
                "IDEF0",
                "BPMN",
                "DFD"
            },
            ListTrueAnswers = new() { "IDEF0" },
            TestId = TestData.BasicsBusinessAnalysisTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsBusinessAnalysis2 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Требование «Пользовательский GUI должен предоставлять возможность языковой локализации: " +
                   "выбор языка (русский/английский) для надписей на элементах» — это",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Бизнес-требование (business requirement)",
                "Требование стейкхолдера (stakeholder requirement)",
                "Нефункциональное требование (non-functional requirement)",
                "Функциональное требование (functional requirement)"
            },
            ListTrueAnswers = new() { "Нефункциональное требование (non-functional requirement)" },
            TestId = TestData.BasicsBusinessAnalysisTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsBusinessAnalysis3 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Аналог BPMN-диаграммы в UML — это",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Диаграмма классов (Class diagram)",
                "Диаграмма деятельности (activity diagram)",
                "Диаграмма состояний (State diagram)",
                "Диаграмма компонентов (Component diagram)"
            },
            ListTrueAnswers = new() { "Диаграмма деятельности (activity diagram)" },
            TestId = TestData.BasicsBusinessAnalysisTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsBusinessAnalysis4 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Разработка требований к программному продукту в Agile-проектах характеризуется",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "появлением новых бизнес-потребностей",
                "итеративностью циклов детализации требований",
                "нестабильным характером требований",
                "отсутствием ТЗ (технического задания) по ГОСТ"
            },
            ListTrueAnswers = new() { "итеративностью циклов детализации требований" },
            TestId = TestData.BasicsBusinessAnalysisTest.Id,
            IsDeleted = false,
        };

        public static readonly Question QuestionForBasicsBusinessAnalysis5 = new()
        {
            Id = Guid.NewGuid(),
            Name = "Организационная структура, которая предполагает двойное подчинение, например, " +
                   "начальнику функциональному отдела и менеджеру проекта, называется",
            QuestionType = QuestionType.OneOfMany,
            NumberOfPoints = 20,
            IconUrl = null,
            ListAnswers = new()
            {
                "Проектная",
                "Распределенная",
                "Процессная",
                "Функциональная"
            },
            ListTrueAnswers = new() { "Проектная" },
            TestId = TestData.BasicsBusinessAnalysisTest.Id,
            IsDeleted = false,
        };

        public static readonly List<Question> QuestionsForBasicsBusinessAnalysisTest = new()
        {
            QuestionForBasicsBusinessAnalysis1,
            QuestionForBasicsBusinessAnalysis2,
            QuestionForBasicsBusinessAnalysis3,
            QuestionForBasicsBusinessAnalysis4,
            QuestionForBasicsBusinessAnalysis5,
        };
    }
}