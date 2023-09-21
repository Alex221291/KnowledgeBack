using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.UserViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dsKnowledgeTest.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [Authorize]
    [Route("Edit")]
    [HttpPost]
    public async Task<ObjectResult> Edit(UpdateUserViewModel model)
    {
        try
        {
            await _userService.EditUserAsync(model);
            return Ok("Данные обновлены успешно");
        }
        catch
        {
            return BadRequest("Ошибка обновления");
        }
    }
    [Authorize]
    [Route("GetById")]
    [HttpGet]
    public async Task<ObjectResult> GetById(string userId)
    {
        var userGuid = Guid.Parse(userId);
        var user = await _userService.GetByIdAsync(userGuid);
        if (user == null) return BadRequest("Пользователь не найден");
        return Ok(user);
    }
}