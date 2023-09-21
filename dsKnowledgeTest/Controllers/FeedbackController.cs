using dsKnowledgeTest.Services;
using dsKnowledgeTest.ViewModels.FeedbackViewMdel;
using Microsoft.AspNetCore.Mvc;

namespace dsKnowledgeTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [Route("Create")]
        [HttpPost]
        public async Task<ObjectResult> Create(CreateFeedbackViewModel model)
        {
            var createFeedback = await _feedbackService.CreateAsync(model);
            if (createFeedback == null) return BadRequest(createFeedback);
            return Ok(createFeedback);
        }
    }
}
