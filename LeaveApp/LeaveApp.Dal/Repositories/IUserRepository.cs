using LeaveApp.Dal.Configuration;
using LeaveApp.Dal.Domain;
using LeaveApp.Dal.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Repositories
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetTopTen(CancellationToken cancellationToken = default);

        Task<int> Save(UserDto user, CancellationToken cancellationToken = default);

        Task<bool> Delete(int UserId, CancellationToken cancellationToken = default);
    }
}
