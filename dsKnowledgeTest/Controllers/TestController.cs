using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.TestViewModel;
using dsKnowledgeTest.ViewModels.TestViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace dsKnowledgeTest.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly ITestService _testService;
    private readonly IExcelParserService _excelParserService;
    private readonly IWebHostEnvironment _environment;

    public TestController(ITestService testService, IExcelParserService excelParserService,
        IWebHostEnvironment environment)
    {
        _testService = testService;
        _excelParserService = excelParserService;
        _environment = environment;
    }

    [Route("GetAllByCategory")]
    [HttpGet]
    public async Task<ObjectResult> GetAllByCategory(string categoryId)
    {
        var categoryGuid = Guid.Parse(categoryId);
        var tests = await _testService.GetAllTestByCategoryAsync(categoryGuid);
        return Ok(tests);
    }

    [Route("SearchTests")]
    [HttpGet]
    public async Task<ObjectResult> SearchTests(string testName)
    {
        var tests = await _testService.SearchTestsAsync(testName);
        return Ok(tests);
    }

    [Route("GetTestById")]
    [HttpGet]
    public async Task<ObjectResult> GetTestById(string testId)
    {
        var test = await _testService.GetTestByIdWithQuestionsAsync(Guid.Parse(testId));
        return Ok(test);
    }

    //[Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("GetTestByIdForAdmin")]
    [HttpGet]
    public async Task<ObjectResult> GetTestByIdForAdmin(string testId)
    {
        var test = await _testService.GetTestByIdWithQuestionsForAdminAsync(Guid.Parse(testId));
        return Ok(test);
    }

    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("Create")]
    [HttpPost]
    public async Task<ObjectResult> Create(CreateTestViewModel test)
    {
        try
        {
            await _testService.CreateTestAsync(test);
            return Ok("Данные добавлены!");
        }
        catch
        {
            return BadRequest("Произошла ошибка!");
        }
    }

    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("CreateTestWithQuestion")]
    [HttpPost]
    public async Task<ObjectResult> CreateTestWithQuestion(CreateTestWithQuestionsViewModel test)
    {
        try
        {
            await _testService.CreateTestWithQuestionsAsync(test);
            return Ok("Данные добавлены!");
        }
        catch
        {
            return BadRequest("Произошла ошибка!");
        }
    }

    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("EditTestWithQuestion")]
    [HttpPost]
    public async Task<ObjectResult> EditTestWithQuestion(EditTestWithQuestionsViewModel test)
    {
        try
        {
            await _testService.EditTestWithQuestionsAsync(test);
            return Ok("Данные обновлены!");
        }
        catch
        {
            return BadRequest("Произошла ошибка!");
        }
    }

    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("Edit")]
    [HttpPost]
    public async Task<ObjectResult> Edit(EditTestViewModel test)
    {
        try
        {
            await _testService.EditTestAsync(test);
            return Ok("Данные обновлены!");
        }
        catch
        {
            return BadRequest("Произошла ошибка!");
        }
    }

    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("Delete")]
    [HttpDelete]
    public async Task<ObjectResult> Delete(string testId)
    {
        try
        {
            await _testService.DeleteTestAsync(Guid.Parse(testId));
            return Ok("Данные удалены!");
        }
        catch
        {
            return BadRequest("Произошла ошибка!");
        }
    }

    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("ImportTest")]
    [HttpPost]
    public async Task<ObjectResult> ImportTest(IFormFile file)
    {
        try
        {
            var parsedTest = await _excelParserService.ParseExcelToTest(file);
            if (parsedTest.GetType() != typeof(CreateTestWithQuestionsViewModel)) return BadRequest(parsedTest);
            try
            {
                await _testService.CreateTestWithQuestionsAsync((CreateTestWithQuestionsViewModel)parsedTest);
                return Ok("Тест добавлен!");
            }
            catch
            {
                return BadRequest("При добавлении в базу произошла ошибка!");
            }
        }
        catch
        {
            return BadRequest("Произошла ошибка при импортировании!");
        }
    }

    [Authorize]
    [Route("GetCommonTest")]
    [HttpGet]
    public async Task<ObjectResult> GetCommonTest(string categoryId)
    {
        try
        {
            var test = await _testService.GetCommonTestAsync(categoryId);
            if (test == null) return BadRequest("Ошибка вводимых данных!");
            return Ok(test);
        }
        catch
        {
            return BadRequest("Ошибка вводимых данных!");
        }
    }

    [Authorize]
    [Route("GetFinalTest")]
    [HttpPost]
    public async Task<ObjectResult> GetFinalTest(CreateFinalTestViewModel model)
    {
        try
        {
            var test = await _testService.GetFinalTestAsync(model);
            if (test == null) return BadRequest("Ошибка вводимых данных!");
            return Ok(test);
        }
        catch
        {
            return BadRequest("Ошибка вводимых данных!");
        }
    }
}