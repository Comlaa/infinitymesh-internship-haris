using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using LeaveApp.Dal.Repositories;
using LeaveApp.Dal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LeaveApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.GetTopTen();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] UserDto user)
        {
            var id = await _userRepository.Save(user);
            return Ok(id);
        }
    }
}
