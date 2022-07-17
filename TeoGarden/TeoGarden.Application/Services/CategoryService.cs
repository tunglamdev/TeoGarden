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
            return await _context.Categories.Where(category => category.IsDeleted==false).Select(category => new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                Image = category.Image,
                CreatedDate = category.CreatedDate,
                UpdatedDate = category.UpdatedDate
            }).ToListAsync();
        }

        public async Task<CategoryViewModel> GetByIdAsync(int Id)
        {
            var category = await _context.Categories.Where(category => category.Id == Id && category.IsDeleted == false).FirstOrDefaultAsync();
            if (category == null)
            {
                return null;
            }
            return new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                Image = category.Image,
                CreatedDate = category.CreatedDate,
                UpdatedDate = category.UpdatedDate
            };
        }

        public async Task<int> CreateAsync(CategoryCreateRequest request)
        {
            if (request == null)
            {
                return 0;
            }
            var category = new Category()
            {
                Name = request.Name,
                Image = request.Image
            };
            await _context.Categories.AddAsync(category);
            var result = await _context.SaveChangesAsync();
            if (result!=1)
            {
                return 0;
            }
            return category.Id;
        }

        public async Task<string> UpdateAsync(CategoryUpdateRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var category = await _context.Categories.FindAsync(request.Id);
            if (category == null || category.IsDeleted == true)
            {
                return null;
            }
            category.Name = request.Name;
            string currentImage = "";
            if (request.Image == "");
            else
            {
                currentImage = category.Image;
                category.Image = request.Image;
            }
            category.UpdatedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            if (currentImage == "") return "";
            else return currentImage;
        }

        public async Task<int> DeleteAsync(int Id)
        {
            var category = await _context.Categories.Where(category => category.Id == Id && category.IsDeleted == false)
                                                    .FirstOrDefaultAsync();
            if(category == null)
            {
                return 0;
            }
            category.IsDeleted = true;
            category.UpdatedDate = DateTime.Now;

            var vegetables = await _context.Vegetables.Where(vegetable => vegetable.CategoryId == Id && vegetable.IsDeleted == false)
                                                        .ToListAsync();
            vegetables.ForEach(vegetable =>
            {
                vegetable.IsDeleted = true;
                vegetable.UpdatedDate = DateTime.Now;

            });

            return await _context.SaveChangesAsync();
        }
    }
}
