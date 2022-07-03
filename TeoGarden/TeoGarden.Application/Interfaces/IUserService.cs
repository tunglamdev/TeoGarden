using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.ShareModel.Requests.User;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAllAsync();
        Task<UserViewModel> GetByIdAsync(int Id);
        Task<UserViewModel> GetByPhoneNumberAsync(string Phone);
        Task<int> RegisterAsync(UserRegisterRequest request);
        Task<int> UpdateInformationAsync(UserUpdateRequest request);
        Task<int> BlockAccountAsync(int Id);
    }
}
