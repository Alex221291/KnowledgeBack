using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.PassedTestViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dsKnowledgeTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PassedTestController : ControllerBase
    {
        private readonly IPassedTestService _passedTestService;

        public PassedTestController(IPassedTestService passedTestService)
        {
            _passedTestService = passedTestService;
        }

        [Authorize]
        [Route("Create")]
        [HttpPost]
        public async Task<ObjectResult> Create(CreatePassedTestViewModel model)
        {
            try
            {
                await _passedTestService.CreatePassedTestAsync(model);
                return Ok("Данные добавлены");
            }
            catch
            {
                return BadRequest("Произошла ошибка");
            }
        }

        [Authorize]
        [Route("GetAllByUser")]
        [HttpGet]
        public async Task<ObjectResult> GetAllByUser(string userId)
        {
            var passedTests = await _passedTestService.GetAllPassedTestsByUserIdAsync(userId);
            return Ok(passedTests);
        }

        [Authorize]
        [Route("GetById")]
        [HttpGet]
        public async Task<ObjectResult> GetById(string passedTestId)
        {
            var passedTests = await _passedTestService.GetByIdAsync(passedTestId);
            return Ok(passedTests);
        }

        [Authorize]
        [Route("GetStatistics")]
        [HttpGet]
        public async Task<ObjectResult> GetStatistics(string userId, int month, int year)
        {
            var statistics = 
                await _passedTestService.GetStatisticsPassedTestsByUserIdAsync(userId, month, year);
            return Ok(statistics);
        }

        [Authorize(Roles = nameof(RolesConst.Admin))]
        [Route("GetAll")]
        [HttpGet]
        public async Task<ObjectResult> GetAll()
        {
            var passedTests = await _passedTestService.GetAllPassedTestsAsync();
            return Ok(passedTests);
        }
    }
}
