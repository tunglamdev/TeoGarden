using Microsoft.AspNetCore.Mvc;
using Refit;
using System.Diagnostics;
using TeoGarden.CustomerWebsite.Models;
using TeoGarden.Sdk.Services;

namespace TeoGarden.CustomerWebsite.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryApi _categoryApi;
        private IVegetableApi _vegetableApi;
        private HomeViewModel _viewData;
        public HomeController()
        {
            _categoryApi = RestService.For<ICategoryApi>("https://localhost:7116");
            _vegetableApi = RestService.For<IVegetableApi>("https://localhost:7116");
            _viewData = new HomeViewModel();
        }

        public async Task<IActionResult> Index()
        {
            var categories = _categoryApi.GetAllAsync().GetAwaiter().GetResult();
            var vegetables = _vegetableApi.GetAllAsync().GetAwaiter().GetResult();
            _viewData.Categories = categories;
            _viewData.Vegetables = vegetables;
            return View(_viewData);
        }
    }
}