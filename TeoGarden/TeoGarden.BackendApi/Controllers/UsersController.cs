using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeoGarden.Application.Interfaces;
using TeoGarden.ShareModel.Requests.User;
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
            var users = await _userService.GetAllAsync();
            if(users == null)
            {
                return NotFound("Can not find any account!");
            }
            return Ok(users);
        }

        [HttpGet("Id")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var user = await _userService.GetByIdAsync(Id);
            if(user == null)
            {
                return NotFound($"Can not find any account with id {Id}");
            }
            return Ok(user);
        }

        [HttpGet("Phone")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByPhoneNumber(string Phone)
        {
            var user = await _userService.GetByPhoneNumberAsync(Phone);
            if (user == null)
            {
                return NotFound($"Can not find any account with phone number {Phone}");
            }
            return Ok(user);
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Register(UserRegisterRequest request)
        //{
        //    var userId = await _userService.RegisterAsync(request);
        //    if (userId == 0)
        //    {
        //        return BadRequest();
        //    }
        //    var user = await _userService.GetByIdAsync(userId);
        //    if( user == null)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(user);
        //}

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update(UserUpdateRequest request)
        {
            var result = await _userService.UpdateInformationAsync(request);
            if (result == 0)
            {
                return BadRequest();
            }
            var user = await _userService.GetByIdAsync(request.Id);
            if (user == null)
            {
                return BadRequest();
            }
            return Ok(user);
        }

        [HttpDelete]
        [AllowAnonymous]
        public async Task<IActionResult> Block(Guid Id)
        {
            var result = await _userService.BlockAccountAsync(Id);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
