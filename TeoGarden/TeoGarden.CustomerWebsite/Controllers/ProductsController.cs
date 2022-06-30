using Microsoft.AspNetCore.Mvc;
using Refit;
using TeoGarden.CustomerWebsite.Models;
using TeoGarden.Sdk.Services;

namespace TeoGarden.CustomerWebsite.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IVegetableApi _vegetableApi;
        private readonly ProductViewModel _viewData;
        public ProductsController()
        {
            _vegetableApi = RestService.For<IVegetableApi>("https://localhost:7116");
            _viewData = new ProductViewModel();
        }

        public async Task<IActionResult> Index()
        {
            var vegetables = _vegetableApi.GetAllAsync().GetAwaiter().GetResult();
            _viewData.Vegetables = vegetables;
            return View(_viewData);
        }

        public async Task<IActionResult> Category(int Id)
        {
            var vegetables = _vegetableApi.GetByCategoryAsync(Id).GetAwaiter().GetResult();
            _viewData.Vegetables = vegetables;
            return View(_viewData);
        }

        public async Task<IActionResult> Detail(int Id)
        {
            var vegetable = _vegetableApi.GetByIdAsync(Id).GetAwaiter().GetResult();
            var vegetables = _vegetableApi.GetByCategoryAsync(vegetable.CategoryId).GetAwaiter().GetResult();
            _viewData.Vegetable = vegetable;
            _viewData.Vegetables = vegetables;
            return View(_viewData);
        }

        public async Task<IActionResult> Search(string Key)
        {
            var vegetables = _vegetableApi.FindByKeyAsync(Key).GetAwaiter().GetResult();
            _viewData.Vegetables = vegetables;
            _viewData.Keyword = Key;
            return View(_viewData);
        }
    }
}
