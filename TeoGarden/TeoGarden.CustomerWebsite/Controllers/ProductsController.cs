using Microsoft.AspNetCore.Mvc;
using Refit;
using TeoGarden.CustomerWebsite.Models;
using TeoGarden.Sdk.Services;

namespace TeoGarden.CustomerWebsite.Controllers
{
    public class ProductsController : Controller
    {
        private IVegetableApi _vegetableApi;
        private HomeViewModel _viewData;
        public ProductsController()
        {
            _vegetableApi = RestService.For<IVegetableApi>("https://localhost:7116");
            _viewData = new HomeViewModel();
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
    }
}
