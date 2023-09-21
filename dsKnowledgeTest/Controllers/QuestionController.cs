using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.QuestionViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dsKnowledgeTest.Controllers;

[ApiController]
[Route("[controller]")]
public class QuestionController : ControllerBase
{
    private readonly IQuestionService _questionService;

    public QuestionController(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    [Route("GetAllByTest")]
    [HttpGet]
    public async Task<ObjectResult> GetAllByTest(string testId)
    {
        var testGuid = Guid.Parse(testId);
        var result = await _questionService.GetAllQuestionForTestAsync(testGuid);
        return Ok(result);
    }

    [Route("GetQuestionById")]
    [HttpGet]
    public async Task<ObjectResult> GetQuestionById(string questionId)
    {
        var question = await _questionService.GetQuestionByIdAsync(Guid.Parse(questionId));
        return Ok(question);
    }

    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("Create")]
    [HttpPost]
    public async Task<ObjectResult> Create(CreateQuestionViewModel question)
    {
        try
        {
            await _questionService.CreateQuestionAsync(question);
            return Ok("Данные добавлены");
        }
        catch
        {
            return BadRequest("Произошла ошибка");
        }
    }
    
    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("Edit")]
    [HttpPost]
    public async Task<ObjectResult> Edit(EditQuestionViewModel question)
    {
        try
        {
            await _questionService.EditQuestionAsync(question);
            return Ok("Данные обновлены");
        }
        catch
        {
            return BadRequest("Произошла ошибка");
        }
    }

    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("Delete")]
    [HttpDelete]
    public async Task<ObjectResult> Delete(string questionId)
    {
        try
        {
            await _questionService.DeleteQuestionAsync(Guid.Parse(questionId));
            return Ok("Данные удалены");
        }
        catch
        {
            return BadRequest("Произошла ошибка");
        }
    }
}