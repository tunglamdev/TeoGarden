using Microsoft.AspNetCore.Mvc;
using Refit;
using TeoGarden.CustomerWebsite.Models;
using TeoGarden.Sdk.Services;
using TeoGarden.ShareModel.Requests.Feedback;
using TeoGarden.ShareModel.Requests.Vegetable;

namespace TeoGarden.CustomerWebsite.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IVegetableApi _vegetableApi;
        private readonly IFeedbackApi _feedbackApi;
        private readonly ProductViewModel _viewData;
        public ProductsController()
        {
            _vegetableApi = RestService.For<IVegetableApi>("https://localhost:7116");
            _feedbackApi = RestService.For<IFeedbackApi>("https://localhost:7116");
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
            var feedbacks = _feedbackApi.GetByVegetableAsync(Id).GetAwaiter().GetResult();
            _viewData.Vegetable = vegetable;
            _viewData.Vegetables = vegetables;
            _viewData.Feedbacks = feedbacks;
            return View(_viewData);
        }

        public async Task<IActionResult> Search(string Key)
        {
            var vegetables = _vegetableApi.FindByKeyAsync(Key).GetAwaiter().GetResult();
            _viewData.Vegetables = vegetables;
            _viewData.Keyword = Key;
            return View(_viewData);
        }

        [HttpPost("{VegetableId}")]
        public async Task<IActionResult> Comment(int VegetableId, FeedbackCreateRequest Rrequest, VegetableStarUpdateRequest Urequest)
        {
            Rrequest.UserId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4");
            _feedbackApi.CreateAsync(Rrequest).GetAwaiter().GetResult();
            Urequest.Stars = _feedbackApi.GetAverageVoteAsync(VegetableId).GetAwaiter().GetResult();
            _vegetableApi.UpdateStarAsync(Urequest).GetAwaiter().GetResult();
            return RedirectToAction("detail", "products", new { @Id = VegetableId });
        }
    }
}
