using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeoGarden.Application.Interfaces;
using TeoGarden.Data.EF;
using TeoGarden.ShareModel.Requests.Vegetable;

namespace TeoGarden.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VegetablesController : ControllerBase
    {
        private readonly IVegetableService _vegetableService;
        public VegetablesController(IVegetableService vegetableService)
        {
            _vegetableService = vegetableService;
        }

        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/vegetables/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var vegetables = await _vegetableService.GetAllAsync();
            vegetables.ForEach(c => c.Image = setImageName(c.Image));
            if (vegetables == null)
            {
                return NotFound("Vegetables can't be found!");
            }
            return Ok(vegetables);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute]int Id)
        {
            var vegetable = await _vegetableService.GetByIdAsync(Id);
            vegetable.Image = setImageName(vegetable.Image);
            if (vegetable == null)
            {
                return NotFound($"Can not find vegetable with id {Id}");
            }
            return Ok(vegetable);
        }

        [HttpGet("Category/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByCategory([FromRoute] int Id)
        {
            var vegetables = await _vegetableService.GetByCategoryAsync(Id);
            vegetables.ForEach(c => c.Image = setImageName(c.Image));
            if (vegetables == null)
            {
                return NotFound($"Can not find vegetables with category id {Id}");
            }
            return Ok(vegetables);
        }

        [HttpGet("Search/{Key}")]
        [AllowAnonymous]
        public async Task<IActionResult> FindByKey([FromRoute] string Key)
        {
            var vegetables = await _vegetableService.FindByKeyAsync(Key);
            vegetables.ForEach(c => c.Image = setImageName(c.Image));
            if (vegetables == null)
            {
                return NotFound($"Can not find vegetables with Key {Key}");
            }
            return Ok(vegetables);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] VegetableCreateRequest request)
        {
            var vegetableId = await _vegetableService.CreateAsync(request);
            if (vegetableId == 0)
            {
                return BadRequest();
            }
            var vegetable = await _vegetableService.GetByIdAsync(vegetableId);
            if (vegetable == null)
            {
                return BadRequest();
            }
            return Ok(vegetable);
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromBody] VegetableUpdateRequest request)
        {
            var result = await _vegetableService.UpdateAsync(request);
            if(result == null)
            {
                return BadRequest();
            }
            var vegetable = await _vegetableService.GetByIdAsync(request.Id);
            if (vegetable == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            var result = await _vegetableService.DeleteAsync(id);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpPut("UpdateStar")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateStar([FromBody] VegetableStarUpdateRequest request)
        {
            var result = await _vegetableService.UpdateStarAsync(request);
            if (result == 0)
            {
                return BadRequest();
            }
            var vegetable = await _vegetableService.GetByIdAsync(request.VegetableId);
            vegetable.Image = setImageName(vegetable.Image);
            if (vegetable == null)
            {
                return BadRequest();
            }
            return Ok(vegetable);
        }
    }
}
