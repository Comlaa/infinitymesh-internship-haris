using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<User> Users { get; }
        IGenericRepository<Role> Role { get; }
        IGenericRepository<Leave> Leave { get; }
        IGenericRepository<UserLeave> UserLeave { get; }

        void Commit();
    }
}
