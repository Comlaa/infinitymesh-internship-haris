using LeaveApp.Dal.Domain;
using LeaveApp.Dal.Repositories;
using LeaveApp.Dal.ViewModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GenericController : Controller
    {
        private readonly IUnitOfWork unitOfWork;


        public GenericController(IUnitOfWork _Unit)
        {
            unitOfWork = _Unit;
        }

        #region UserController
        [HttpGet]
        public async Task<UserViewModel> GetUsers()
        {
            return new UserViewModel(await unitOfWork.Users.GetTopTen());

        }

        [HttpGet]
        public UserDto GetUserById(int Id)
        {
            return new UserDto(unitOfWork.Users.getById(Id));

        }

        [HttpPost]
        public async Task<UserDto> AddUser([FromBody] User User)
        {
             await unitOfWork.Users.AddObject(new User(User));

            return new UserDto(User);
        }
        #endregion

        #region LeaveController
        [HttpGet]
        public async Task<LeaveViewModel> GetLeaves()
        {
            System.Diagnostics.Debug.WriteLine("GetLeavesGotCalled!!!");
            return new LeaveViewModel(await unitOfWork.Leave.GetTopTen());


        }

        [HttpGet]
        public LeaveDto GetLeaveById(int Id)
        {
            
            return new LeaveDto(unitOfWork.Leave.getById(Id));

        }

        [HttpPost]
        public async Task<LeaveDto> AddLeave([FromBody] Leave Leave)
        {
            
            await unitOfWork.Leave.AddObject(new Leave(Leave));

            return new LeaveDto(Leave);
        }
        #endregion
    }
}
