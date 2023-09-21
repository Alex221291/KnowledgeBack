using dsKnowledgeTest.Models;

namespace dsKnowledgeTest.Data.Init
{
    public static class CategoryData
    {
        public static readonly Category CSharpCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "Язык программирования C#",
            Description = "C# — объектно-ориентированный язык программирования общего назначения. " +
                          "Разработан в 1998—2001 годах группой инженеров компании Microsoft под руководством " +
                          "Андерса Хейлсберга и Скотта Вильтаумота как язык разработки приложений для платформы Microsoft " +
                          ".NET Framework и .NET Core. последствии был стандартизирован как ECMA-334 и ISO/IEC 23270.",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly Category JavaScriptCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "Язык программирования JavaScript",
            Description = "JavaScript — мультипарадигменный язык программирования. " +
                          "Поддерживает объектно-ориентированный, императивный и функциональный стили. " +
                          "Является реализацией спецификации ECMAScript (стандарт ECMA-262).",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly Category AlgorithmizationCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "Алгоритмизация и программирование",
            Description = "Алгоритмизация – это процесс построения алгоритма решения задачи, " +
                          "результатом которого является выделение этапов процесса обработки данных, " +
                          "формальная запись содержания этих этапов и определение порядка их выполнения.",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly Category BusinessAnalysisCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "Бизнес анализ",
            Description = "Бизнес‑анализ — это изучение деятельности компании в широком смысле: " +
                          "анализ стратегии развития предприятия, его бизнес-процессов, " +
                          "организационной структуры и парка информационных систем, проектирование и " +
                          "настройка взаимодействия всего этого с бизнес‑окружением и внешней средой.",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly Category TestingCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "Тестирование программного обеспечения",
            Description = "Тестирование программного обеспечения-это исследование, " +
                          "проводимое с целью предоставления заинтересованным сторонам информации о " +
                          "качестве тестируемого программного продукта или услуги. " +
                          "Тестирование программного обеспечения также может обеспечить объективный, " +
                          "независимый взгляд на программное обеспечение, позволяющий бизнесу оценить " +
                          "и понять риски внедрения программного обеспечения.",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly Category PythonCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "Язык программирования Python",
            Description = "Python - это высокоуровневый язык программирования общего назначения. " +
                          "Его философия дизайна подчеркивает удобочитаемость кода с использованием значительных отступов." +
                          "Python динамически типизируется и собирает мусор. " +
                          "Он поддерживает несколько парадигм программирования, " +
                          "включая структурированное (особенно процедурное), объектно-ориентированное и функциональное программирование. " +
                          "Его часто называют языком с включенными батарейками из-за его обширной стандартной библиотеки.",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly Category JavaCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "Язык программирования Java",
            Description = "Java — строго типизированный объектно-ориентированный язык программирования общего назначения," +
                          "разработанный компанией Sun Microsystems (в последующем приобретённой компанией Oracle). " +
                          "Разработка ведётся сообществом, организованным через Java Community Process; " +
                          "язык и основные реализующие его технологии распространяются по лицензии GPL." +
                          "Права на торговую марку принадлежат корпорации Oracle.",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly Category KotlinCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "Язык программирования Kotlin",
            Description = "Kotlin (Ко́тлин) — статически типизированный, объектно-ориентированный язык программирования, " +
                          "работающий поверх Java Virtual Machine и разрабатываемый компанией JetBrains. " +
                          "Также компилируется в JavaScript и в исполняемый код ряда платформ через инфраструктуру LLVM. " +
                          "Язык назван в честь острова Котлин в Финском заливе, на котором расположен город Кронштадт.",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly Category HtmlCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "HTML",
            Description = "HTML — стандартизированный язык гипертекстовой разметки документов для просмотра веб-страниц" +
                          "в браузере. Веб-браузеры получают HTML документ от сервера по протоколам HTTP/HTTPS " +
                          "или открывают с локального диска, далее интерпретируют код в интерфейс, " +
                          "который будет отображаться на экране монитора.",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly Category CssCategory = new()
        {
            Id = Guid.NewGuid(),
            Name = "CSS",
            Description = @"CSS — формальный язык описания внешнего вида документа (веб-страницы),
                            написанного с использованием языка разметки (чаще всего HTML или XHTML). 
                            Также может применяться к любым XML-документам, например, к SVG или XUL.",
            CntTest = 1,
            ImageUrl = null,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            IsDeleted = false,
        };

        public static readonly List<Category> Categories = new()
        {
            CSharpCategory, 
            JavaScriptCategory, 
            AlgorithmizationCategory,
            BusinessAnalysisCategory,
            TestingCategory, 
            PythonCategory,
            JavaCategory,
            KotlinCategory,
            HtmlCategory,
            CssCategory,
        };
    }
}