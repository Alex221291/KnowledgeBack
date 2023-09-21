using dsKnowledgeTest.Constants;
using dsKnowledgeTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dsKnowledgeTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class InitDataDatabaseController : ControllerBase
    {
        private readonly IInitDataDatabaseService _initDataDatabaseService;

        public InitDataDatabaseController(IInitDataDatabaseService initDataDatabaseService)
        {
            _initDataDatabaseService = initDataDatabaseService;
        }

        //[Authorize(Roles = nameof(RolesConst.Admin))]
        [Route("Init")]
        [HttpPost]
        public async Task<ObjectResult> Init()
        {
            var resultMessage =  await _initDataDatabaseService.InitDataDatabaseAsync();
            return Ok(resultMessage);
        }
    }
}
