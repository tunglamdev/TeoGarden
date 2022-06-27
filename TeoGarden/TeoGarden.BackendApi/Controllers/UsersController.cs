using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeoGarden.Application.Interfaces;
using TeoGarden.ShareModel.ViewModels;

namespace TeoGarden.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var user = await _userService.GetAllAsync();
            return Ok(user);
        }

        [HttpGet("Id")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(int Id)
        {
            var user = await _userService.GetByIdAsync(Id);
            return Ok(user);
        }

        [HttpGet("Phone")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByPhoneNumber(string Phone)
        {
            var user = await _userService.GetByPhoneNumberAsync(Phone);
            return Ok(user);
        }
    }
}
