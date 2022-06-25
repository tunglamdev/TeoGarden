using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Application.Interfaces
{
    public interface ICategoryService
    {
        public Task<List<CategoryViewModel>> GetAllAsync();
    }
}