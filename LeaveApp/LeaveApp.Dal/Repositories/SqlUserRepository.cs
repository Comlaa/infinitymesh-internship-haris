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
        public async Task<UserViewModel> GetTopTen(CancellationToken cancellationToken = default)
        {
            int MaxNumber = 10;
            var collection = await _LeaveAppContext.Users.Take(MaxNumber).ToListAsync(cancellationToken);

            return new UserViewModel(collection);
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
    }
}
