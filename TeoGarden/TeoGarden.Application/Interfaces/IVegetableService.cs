using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.ShareModel.Requests.Vegetable;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Application.Interfaces
{
    public interface IVegetableService
    {
        Task<List<VegetableViewModel>> GetAllAsync();
        Task<VegetableViewModel> GetByIdAsync(int Id);
        Task<List<VegetableViewModel>> GetByCategoryAsync(int Id);
        Task<List<VegetableViewModel>> FindByKeyAsync(string Key);
        Task<int> CreateAsync(VegetableCreateRequest request);
        Task<int> UpdateAsync(VegetableUpdateRequest request);
        Task<int> DeleteAsync(int Id);
    }
}
