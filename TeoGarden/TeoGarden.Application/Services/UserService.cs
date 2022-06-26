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
    public class UserService : IUserService
    {
        internal readonly TeoGardenDbContext _context;
        public UserService(TeoGardenDbContext context)
        {
            _context = context;
        }
        public async Task<List<UserViewModel>> GetAllAsync()
        {
            return await _context.Users.Select(user => new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Phone = user.Phone,
                Address = user.Address,
                Email = user.Email,
                Avatar = user.Avatar
            }).ToListAsync();
        }

        public async Task<UserViewModel> GetByIdAsync(int Id)
        {
            var user = await _context.Users.Where(user => user.Id == Id).FirstOrDefaultAsync();
            return new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Phone = user.Phone,
                Address = user.Address,
                Email = user.Email,
                Avatar = user.Avatar
            };
        }

        public async Task<UserViewModel> GetByPhoneNumberAsync(string Phone)
        {
            var user = await _context.Users.Where(user => user.Phone == Phone).FirstOrDefaultAsync();
            return new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Phone = user.Phone,
                Address = user.Address,
                Email = user.Email,
                Avatar = user.Avatar
            };
        }
    }
}
