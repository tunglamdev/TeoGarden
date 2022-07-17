using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeoGarden.Application.Interfaces;
using TeoGarden.Data.Models;
using TeoGarden.ShareModel.Requests.Feedback;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacksController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;
        public FeedbacksController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/users/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var feedbacks = await _feedbackService.GetAllAsync();
            if(feedbacks == null)
            {
                return NotFound("Feedbacks can't be found");
            }
            return Ok(feedbacks);
        }
    
        [HttpGet("Id")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(int Id)
        {
            var feedback = await _feedbackService.GetByIdAsync(Id);
            feedback.Avatar = setImageName(feedback.Avatar);
            if (feedback == null)
            {
                return NotFound($"Can not find any feedback with id {Id}");
            }
            return Ok(feedback);
        }

        [HttpGet("GetByVegetable/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByVegetableId([FromRoute] int Id)
        {
            var feedbacks = await _feedbackService.GetByVegetableIdAsync(Id);
            feedbacks.ForEach(f => f.Avatar = setImageName(f.Avatar));
            if (feedbacks == null)
            {
                return NotFound($"Can not find any feedback for the product {Id}");
            }
            return Ok(feedbacks);
        }

        [HttpGet("GetByUser/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByUserId(Guid Id)
        {
            var feedbacks = await _feedbackService.GetByUserIdAsync(Id);
            if(feedbacks == null)
            {
                return NotFound($"Can not find any feedback commented by user {Id}");
            }
            return Ok(feedbacks);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] FeedbackCreateRequest request)
        {
            var feedbackId = await _feedbackService.CreateAsync(request);
            if (feedbackId == 0)
            {
                return BadRequest();
            }
            var feedback = await _feedbackService.GetByIdAsync(feedbackId);
            if(feedback == null)
            {
                return BadRequest();
            }
            return Ok(feedback);
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromBody] FeedbackUpdateRequest request)
        {
            var result = await _feedbackService.UpdateAsync(request);
            if(result == 0)
            {
                return BadRequest();
            }
            var feedback = await _feedbackService.GetByIdAsync(request.Id);
            if (feedback == null)
            {
                return BadRequest();
            }
            return Ok(feedback);
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _feedbackService.DeleteAsync(Id);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpGet("AverageVote/{vegetableId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAverageVote(int vegetableId)
        {
            var avg = await _feedbackService.GetAverageVoteAsync(vegetableId);
            return Ok(avg);
        }
    }
}
