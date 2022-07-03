using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Application.Interfaces;
using TeoGarden.Data.EF;
using TeoGarden.Data.Models;
using TeoGarden.ShareModel.Requests.User;
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
            return await _context.Users.Where(user=>user.IsBlocked==false).Select(user => new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Phone = user.Phone,
                Address = user.Address,
                Email = user.Email,
                Avatar = user.Avatar,
                RegisteredDate = user.RegisteredDate,
                UpdatedDate = user.UpdatedDate
            }).ToListAsync();
        }

        public async Task<UserViewModel> GetByIdAsync(int Id)
        {
            var user = await _context.Users.Where(user => user.Id == Id && user.IsBlocked == false).FirstOrDefaultAsync();
            if(user == null)
            {
                return null;
            }
            return new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Phone = user.Phone,
                Address = user.Address,
                Email = user.Email,
                Avatar = user.Avatar,
                RegisteredDate = user.RegisteredDate,
                UpdatedDate = user.UpdatedDate
            };
        }

        public async Task<UserViewModel> GetByPhoneNumberAsync(string Phone)
        {
            var user = await _context.Users.Where(user => user.Phone == Phone && user.IsBlocked == false).FirstOrDefaultAsync();
            if (user == null)
            {
                return null;
            }
            return new UserViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                Phone = user.Phone,
                Address = user.Address,
                Email = user.Email,
                Avatar = user.Avatar,
                RegisteredDate = user.RegisteredDate,
                UpdatedDate = user.UpdatedDate
            };
        }

        public async Task<int> RegisterAsync(UserRegisterRequest request)
        {
            if (request == null)
            {
                return 0;
            }
            var email = _context.Users.Where(user => user.Email == request.Email).FirstOrDefaultAsync();
            if(email != null)
            {
                return 0;
            }
            var user = new User()
            {
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
                Address = request.Address,
                Password = request.Password
            };
            await _context.Users.AddAsync(user);
            var result = await _context.SaveChangesAsync();
            if (result == 0)
            {
                return 0;
            }
            return user.Id;
        }

        public async Task<int> UpdateInformationAsync(UserUpdateRequest request)
        {
            if (request == null)
            {
                return 0;
            }
            var user = await _context.Users.FindAsync(request.Id);
            if(user == null || user.IsBlocked == true)
            {
                return 0;
            }
            user.Name = request.Name;
            user.Email = request.Email;
            user.Phone = request.Phone;
            user.Avatar = request.Avatar;
            user.UpdatedDate = DateTime.Now;
            return await _context.SaveChangesAsync();
        }

        public async Task<int> BlockAccountAsync(int Id)
        {
            var user = await _context.Users.Where(user => user.Id==Id && user.IsBlocked == false).FirstOrDefaultAsync();
            if (user == null)
            {
                return 0;
            }
            user.IsBlocked = true;
            user.UpdatedDate = DateTime.Now;
            return await _context.SaveChangesAsync();
        }

        //public async Task<string> LoginAsync(UserLoginRequest request)
        //{
        //    return "";
        //}
    }
}
