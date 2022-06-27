using TeoGarden.ShareModel.Requests.Category;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Application.Interfaces
{
    public interface ICategoryService
    {
        public Task<List<CategoryViewModel>> GetAllAsync();
        public Task<CategoryViewModel> GetByIdAsync(int Id);
        public Task<int> CreateAsync(CategoryCreateRequest request);
        public Task<int> UpdateAsync(CategoryUpdateRequest request);
        //public Task<int> DeleteAsync(int Id);
    }
}