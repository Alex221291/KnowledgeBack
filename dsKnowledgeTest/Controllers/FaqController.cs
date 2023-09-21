using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.FaqViewModel;
using Microsoft.AspNetCore.Mvc;

namespace dsKnowledgeTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FaqController : ControllerBase
    {
        private readonly IFaqService _faqService;

        public FaqController(IFaqService faqService)
        {
            _faqService = faqService;
        }

        [Route("GetAll")]
        [HttpGet]
        public async Task<List<FaqViewModel>> GetAll() =>
            await _faqService.GetAllAsync();

        [Route("GetFaqForAuthorizations")]
        [HttpGet]
        public async Task<List<FaqViewModel>> GetFaqForAuthorizations() =>
            await _faqService.GetFaqForAuthorizationsAsync();


        [Route("GetFaqForStudents")]
        [HttpGet]
        public async Task<List<FaqViewModel>> GetFaqForStudents() => 
            await _faqService.GetFaqForStudentsAsync();


        [Route("GetFaqForTeachers")]
        [HttpGet]
        public async Task<List<FaqViewModel>> GetFaqForTeachers() => 
            await _faqService.GetFaqForTeachersAsync();
    }
}