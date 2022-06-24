using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeoGarden.Data.EF;

namespace TeoGarden.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VegetablesController : ControllerBase
    {
        private readonly TeoGardenDbContext _context;
        public VegetablesController(TeoGardenDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var vegetables = _context.Vegetables.ToList();
            return Ok(vegetables);
        }
    }
}
