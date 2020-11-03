using LeaveApp.Dal.Domain;
using LeaveApp.Dal.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApp.Dal.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private LeaveAppDbContext _DbContext;
        private GenericRepository<User> _Users;
        private GenericRepository<Role> _Roles;
        private GenericRepository<Leave> _Leaves;
        private GenericRepository<UserLeave> _UserLeaves;

        public UnitOfWork(LeaveAppDbContext context)
        {
            _DbContext = context;
        }
        public IGenericRepository<User> Users
        {
            get
            {
                return _Users ??= new GenericRepository<User>(_DbContext);
            }
        }

        public IGenericRepository<Role> Role
        {
            get
            {
                return _Roles ??= new GenericRepository<Role>(_DbContext);
            }
        }

        public IGenericRepository<Leave> Leave
        {
            get
            {
                return _Leaves ??= new GenericRepository<Leave>(_DbContext);
            }
        }

        public IGenericRepository<UserLeave> UserLeave
        {
            get
            {
                return _UserLeaves ??= new GenericRepository<UserLeave>(_DbContext);
            }
        }

        public void Commit()
        {
            _DbContext.SaveChanges();
        }
    }
}
