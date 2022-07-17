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
            categories.ForEach(c => c.Image = String.Format("{0}://{1}{2}/images/categories/{3}", Request.Scheme, Request.Host, Request.PathBase, c.Image));
            if (categories == null)
            {
                return NotFound("Can't find any catgory!");
            }
            return Ok(categories);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute]int Id)
        {
            var category = await _categoryService.GetByIdAsync(Id);
            category.Image = String.Format("{0}://{1}{2}/images/categories/{3}", Request.Scheme, Request.Host, Request.PathBase, category.Image);
            if (category == null)
            {
                return NotFound($"Cannot find a category with Id: {Id}");
            }
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

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromBody] CategoryUpdateRequest request)
        {
            var result = await _categoryService.UpdateAsync(request);
            if (result == null)
            {
                return BadRequest();
            }
            var data = await _categoryService.GetByIdAsync(request.Id);
            if (data == null)
            {
                return NotFound($"Cannot find category with Id: {request.Id}");
            }
            return Ok(result);
        }

        [HttpDelete("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete([FromRoute]int Id)
        {
            var result = await _categoryService.DeleteAsync(Id);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
