using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeoGarden.Application.Interfaces;
using TeoGarden.Data.EF;
using TeoGarden.ShareModel.Requests.Category;

namespace TeoGarden.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("Id")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int Id)
        {
            var category = await _categoryService.GetByIdAsync(Id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryCreateRequest request)
        {
            var categoryId = await _categoryService.CreateAsync(request);
            if (categoryId == 0)
            {
                return BadRequest();
            }
            var data = await _categoryService.GetByIdAsync(categoryId);
            if (data == null)
            {
                return NotFound($"Cannot find category with Id: {categoryId}");
            }
            return Ok(data);
        }
    }
}
