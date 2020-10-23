using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Repositories
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetTopTen(CancellationToken cancellationToken = default);
    }
}
