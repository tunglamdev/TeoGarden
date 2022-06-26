using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Application.Interfaces;
using TeoGarden.Data.EF;
using TeoGarden.Data.Models;
using TeoGarden.ShareModel.Requests.Category;
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
        public async Task<CategoryViewModel> GetByIdAsync(int Id)
        {
            var category = await _context.Categories.Where(category => category.Id == Id).FirstOrDefaultAsync();
            return new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                Image = category.Image
            };
        }
        public async Task<int> CreateAsync(CategoryCreateRequest request)
        {
            var category = new Category()
            {
                Name = request.Name,
                Image = request.Image
            };
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category.Id;
        }
        public async Task<int> UpdateAsync(CategoryUpdateRequest request)
        {
            var category = await _context.Categories.FindAsync(request.Id);
            category.Name = request.Name;
            category.Image = request.Image;
            return await _context.SaveChangesAsync();
        }

        //public async Task<int> DeleteAsync(int Id)
        //{
        //    var category = _context.Categories.Where(category => category.Id == Id).FirstOrDefaultAsync();
        //    _context.Categories.Remove(category);
        //    return await _context.SaveChangesAsync();
        //}
    }
}
