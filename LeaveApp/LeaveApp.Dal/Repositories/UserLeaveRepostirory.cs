using LeaveApp.Dal.Domain;
using LeaveApp.Dal.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Repositories
{
    public class UserLeaveRepostirory : IUserLeaveRepository
    {
        private LeaveAppDbContext Context;
        public UserLeaveRepostirory(LeaveAppDbContext context)
        {
            Context = context;
        }
        public async Task<IReadOnlyCollection<UserLeave>> GetUserLeaves(int userId, CancellationToken cancellationToken = default)
        {

            return await Context.UserLeaves.Take(100).Where(x => x.UserId == userId).ToListAsync(cancellationToken);
            
        }
    }
}
