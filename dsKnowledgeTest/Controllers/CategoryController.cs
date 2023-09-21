using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.CategoryViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dsKnowledgeTest.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [Route("GetAll")]
    [HttpGet]
    public async Task<ObjectResult> GetAll()
    {
        var result = await _categoryService.GetAllCategoriesAsync();
        return Ok(result);
    }

    [Route("GetCategoryById")]
    [HttpGet]
    public async Task<ObjectResult> GetCategoryById(string categoryId)
    {
        var category = await _categoryService.GetCategoryByIdAsync(Guid.Parse(categoryId));
        return Ok(category);
    }

    [Authorize(Roles = nameof(RolesConst.Admin))]
    [Route("Create")]
    [HttpPost]
    public async Task<ObjectResult> Create(CreateCategoryViewModel category)
    {
        try
        {
            await _categoryService.CreateCategoryAsync(category);
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
    public async Task<ObjectResult> Edit(EditCategoryViewModel category)
    {
        try
        {
            await _categoryService.EditCategoryAsync(category);
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
    public async Task<ObjectResult> Delete(string categoryId)
    {
        try
        {
            await _categoryService.DeleteCategoryAsync(Guid.Parse(categoryId));
            return Ok("Данные удалены");
        }
        catch
        {
            return BadRequest("Произошла ошибка");
        }
    }

    [Authorize]
    [Route("GetCountQuestionsInCategory")]
    [HttpGet]
    public async Task<ObjectResult> GetCountQuestionsInCategory(string categoryId)
    {
        var count = await _categoryService.GetCountQuestionsInCategory(categoryId);
        return Ok(count);
    }
}