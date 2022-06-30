using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Application.Interfaces;
using TeoGarden.Data.EF;
using TeoGarden.Data.Models;
using TeoGarden.ShareModel.Requests.Vegetable;
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
            return await _context.Vegetables.Where(vegetable => vegetable.IsDeleted==false)
                                            .Select(vegetable => new VegetableViewModel()
            {
                Id = vegetable.Id,
                Name = vegetable.Name,
                Price = vegetable.Price,
                Weight = vegetable.Weight,
                Image = vegetable.Image,
                IsSale = vegetable.IsSale,
                Location = vegetable.Location,
                CategoryId = vegetable.CategoryId,
                CreatedDate = vegetable.CreatedDate,
                UpdatedDate = vegetable.UpdatedDate
            }).ToListAsync();
        }

        public async Task<VegetableViewModel> GetByIdAsync(int Id)
        {
            var vegetable = await _context.Vegetables.Where(vegetable => vegetable.Id==Id && vegetable.IsDeleted == false)
                                                        .FirstOrDefaultAsync();
            if (vegetable == null)
            {
                return null;
            }
            return new VegetableViewModel()
            {
                Id = vegetable.Id,
                Name = vegetable.Name,
                Price  = vegetable.Price,
                Weight = vegetable.Weight,
                Image = vegetable.Image,
                IsSale = vegetable.IsSale,
                Location = vegetable.Location,
                CategoryId = vegetable.CategoryId,
                CreatedDate = vegetable.CreatedDate,
                UpdatedDate = vegetable.UpdatedDate
            };
        }

        public async Task<List<VegetableViewModel>> GetByCategoryAsync(int Id)
        {
            var category = await _context.Categories.Where(category => category.Id == Id && category.IsDeleted == false).FirstOrDefaultAsync();
            if (category == null)
            {
                return null;
            }
            var vegetables = await _context.Vegetables.Where(vegetable => vegetable.CategoryId == Id && vegetable.IsDeleted == false)
                                                    .Select(vegetable => new VegetableViewModel()
                                                    {
                                                        Id = vegetable.Id,
                                                        Name = vegetable.Name,
                                                        Price = vegetable.Price,
                                                        Weight = vegetable.Weight,
                                                        Image = vegetable.Image,
                                                        IsSale = vegetable.IsSale,
                                                        Location = vegetable.Location,
                                                        CategoryId = vegetable.CategoryId,
                                                        CreatedDate = vegetable.CreatedDate,
                                                        UpdatedDate = vegetable.UpdatedDate
                                                    }).ToListAsync();
            if (vegetables == null)
            {
                return null;
            }
            return vegetables;
        }

        public async Task<List<VegetableViewModel>> FindByKeyAsync(string key)
        {
            if(key == null)
            {
                return null;
            }
            var vegetables = _context.Vegetables.Where(vegetable => vegetable.Name.Contains(key) && vegetable.IsDeleted == false)
                                                    .Select(vegetable => new VegetableViewModel()
                                                    {
                                                        Id = vegetable.Id,
                                                        Name = vegetable.Name,
                                                        Price = vegetable.Price,
                                                        Weight = vegetable.Weight,
                                                        Image = vegetable.Image,
                                                        IsSale = vegetable.IsSale,
                                                        Location = vegetable.Location,
                                                        CategoryId = vegetable.CategoryId,
                                                        CreatedDate = vegetable.CreatedDate,
                                                        UpdatedDate = vegetable.UpdatedDate
                                                    }).ToListAsync();
            if (vegetables == null)
            {
                return null;
            }
            return await vegetables;
        }

        public async Task<int> CreateAsync(VegetableCreateRequest request)
        {
            if (request == null)
            {
                return 0;
            }
            var vegetable = new Vegetable()
            {
                Name = request.Name,
                Price = request.Price,
                Weight = request.Weight,
                Image = request.Image,
                Location = request.Location,
                CategoryId = request.CategoryId
            };
            await _context.Vegetables.AddAsync(vegetable);
            var result = await _context.SaveChangesAsync();
            if (result == 0)
            {
                return 0;
            }
            return vegetable.Id;
        }

        public async Task<int> UpdateAsync(VegetableUpdateRequest request)
        {
            if (request == null)
            {
                return 0;
            }
            var vegetable = await _context.Vegetables.FindAsync(request.Id);
            if(vegetable == null || vegetable.IsDeleted==true)
            {
                return 0;
            }
            vegetable.Name = request.Name;
            vegetable.Price = request.Price;
            vegetable.Weight = request.Weight;
            vegetable.Location = request.Location;
            vegetable.CategoryId = request.CategoryId;
            vegetable.UpdatedDate = DateTime.Now;
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int Id)
        {
            var vegetable = await _context.Vegetables.Where(vegetable => vegetable.Id==Id && vegetable.IsDeleted==false)
                                                        .FirstOrDefaultAsync();
            if (vegetable == null)
            {
                return 0;
            }
            vegetable.IsDeleted = true;
            vegetable.UpdatedDate = DateTime.Now;
            return await _context.SaveChangesAsync();
        }
    }
}
