using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Application.Interfaces
{
    public interface IVegetableService
    {
        Task<List<VegetableViewModel>> GetAllAsync();
    }
}
