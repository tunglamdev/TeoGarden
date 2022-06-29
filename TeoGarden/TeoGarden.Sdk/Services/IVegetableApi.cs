using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Sdk.Services
{
    public interface IVegetableApi
    {
        [Get("/api/Vegetables")]
        Task<List<VegetableViewModel>> GetAllAsync();

        [Get("/api/Vegetables/Category/Id")]
        Task<List<VegetableViewModel>> GetByCategoryAsync(int Id);
    }
}
