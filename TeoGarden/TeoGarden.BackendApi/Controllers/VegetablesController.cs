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
            return Ok(vegetables);
        }

        [HttpGet("Id")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int Id)
        {
            var vegetable = await _vegetableService.GetByIdAsync(Id);
            return Ok(vegetable);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] VegetableCreateRequest request)
        {
            var vegetableId = await _vegetableService.CreateAsync(request);
            var vegetable = await _vegetableService.GetByIdAsync(vegetableId);
            return Ok(vegetable);
        }
    }
}
