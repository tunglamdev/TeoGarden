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
    public class CategoryService : ICategoryService
    {
        private readonly TeoGardenDbContext _context;
        public CategoryService(TeoGardenDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<CategoryViewModel>> GetAllAsync()
        {
            return await _context.Categories.Select(category => new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                Image = category.Image
            }).ToListAsync();
        }
    }
}
