using dsKnowledgeTest.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dsKnowledgeTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DownloadController : ControllerBase
    {
        private string fileName = "test_template.xlsx";
        private string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        private readonly string _filePath;
        private readonly IWebHostEnvironment _env;

        public DownloadController(string filePath, IWebHostEnvironment env)
        {
            _filePath = filePath;
            _env = env;
        }

        [Authorize(Roles = nameof(RolesConst.Admin))]
        [HttpGet]
        [Route("DownloadTemplate")]
        public FileContentResult DownloadTemplate()
        {
            
            Console.WriteLine("dt ---------" + _filePath);
            return File(
                System.IO.File.ReadAllBytes(_filePath),
                contentType, 
                fileName);
        }

        [Authorize(Roles = nameof(RolesConst.Admin))]
        [HttpGet]
        [Route("DownloadFile")]
        public async Task<IActionResult> DownloadFile()
        {

            var path = Path.Combine(_env.ContentRootPath, fileName);
            Console.WriteLine("df ---------" + path);
            var memory = new MemoryStream();
            await using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, contentType, Path.GetFileName(path));
        }
    }
}
