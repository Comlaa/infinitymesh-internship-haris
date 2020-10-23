using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LeaveApp.Dal.Repositories;
using Microsoft.AspNetCore.Mvc;š
using Microsoft.Extensions.Logging;

namespace LeaveApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;
        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userRepository.GetTopTen();
            return Ok(users);
        }
    }
}
