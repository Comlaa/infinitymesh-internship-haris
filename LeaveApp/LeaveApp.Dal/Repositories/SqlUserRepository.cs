using LeaveApp.Dal.Domain;
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
        public async Task<ICollection<User>> GetTopTen(CancellationToken cancellationToken = default)
        {
            int MaxNumber = 10;
            return await _LeaveAppContext.Users.Take(MaxNumber).ToListAsync(cancellationToken);
            
        }


    }
}
