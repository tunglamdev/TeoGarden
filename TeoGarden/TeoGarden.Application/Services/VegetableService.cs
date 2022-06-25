using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Application.Interfaces;
using TeoGarden.Data.EF;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Application.Services
{
    public class VegetableService : IVegetableService
    {
        public readonly TeoGardenDbContext _context;

        public VegetableService(TeoGardenDbContext context)
        {
            _context = context;
        }

        public async Task<List<VegetableViewModel>> GetAllAsync()
        {
            return await _context.Vegetables.Select(vegetable => new VegetableViewModel()
            {
                Id = vegetable.Id,
                Name = vegetable.Name,
                Price = vegetable.Price,
                Weight = vegetable.Weight,
                Image = vegetable.Image,
                Location = vegetable.Location,
                CategoryId = vegetable.CategoryId
            }).ToListAsync();
        }
    }
}
