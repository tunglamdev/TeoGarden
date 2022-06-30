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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var vegetables = await _vegetableService.GetAllAsync();
            if(vegetables == null)
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
            if(result == 0)
            {
                return BadRequest();
            }
            var vegetable = await _vegetableService.GetByIdAsync(request.Id);
            if (vegetable == null)
            {
                return BadRequest();
            }
            return Ok(vegetable);
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _vegetableService.DeleteAsync(Id);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
