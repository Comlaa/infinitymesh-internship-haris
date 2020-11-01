using LeaveApp.Dal.Domain;
using LeaveApp.Dal.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Repositories
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly LeaveAppDbContext _LeaveAppContext;
        public SqlUserRepository(LeaveAppDbContext leaveAppDbContext)
        {
            _LeaveAppContext = leaveAppDbContext;
        }

        public async Task<bool> Delete(int UserId, CancellationToken cancellationToken = default)
        {
            var user = _LeaveAppContext.Users.Find(UserId);

            _LeaveAppContext.Users.Remove(user);
            await _LeaveAppContext.SaveChangesAsync(cancellationToken);

            return true;
        }

        public async Task<List<User>> GetTopTen(CancellationToken cancellationToken = default)
        {
            int MaxNumber = 10;
            //var collection = await _LeaveAppContext.Users.Take(MaxNumber).ToListAsync(cancellationToken);
            return await _LeaveAppContext.Users.Take(MaxNumber).ToListAsync(cancellationToken);

            //return new UserViewModel(collection);
        }

        public async Task<int> Save(UserDto user, CancellationToken cancellationToken = default)
        {
            var UserDomain = new User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Department = user.Department,
                JobTitle = user.JobTitle,
                Password = Guid.NewGuid().ToString("n"),
            };

            await _LeaveAppContext.Users.AddAsync(UserDomain, cancellationToken);
            await _LeaveAppContext.SaveChangesAsync(cancellationToken);

            return UserDomain.Id;
        }

        public void UpdateUser(int UserId, UserDto user)
        {
            var ActiveUser = _LeaveAppContext.Users.Find(UserId);

            ActiveUser.Name = user.Name;
            ActiveUser.JobTitle = user.JobTitle;
            ActiveUser.Department = user.Department;
            ActiveUser.Email = user.Email;

             _LeaveAppContext.SaveChanges();
        }
    }
}
