using Refit;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Sdk.Services
{
    public interface ICategoryApi
    {
        [Get("/api/Categories")]
        Task<List<CategoryViewModel>> GetAllAsync();
    }
}