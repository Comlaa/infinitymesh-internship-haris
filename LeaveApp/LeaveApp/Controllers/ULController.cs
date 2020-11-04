using LeaveApp.Dal.Repositories;
using LeaveApp.Dal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ULController : Controller
    {
        private readonly IUserLeaveRepository inter;

        public ULController(IUserLeaveRepository _inter)
        {
            inter = _inter;
        }

        [HttpGet]
        public async Task<List<UserLeaveDto>> GetUserLeaves(int UserId)
        {

            var collection = await inter.GetUserLeaves(UserId);
            return new List<UserLeaveDto>(collection.Select(user => new UserLeaveDto(user)));

        }
    }
}
