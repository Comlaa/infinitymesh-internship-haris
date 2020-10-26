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

        public void Commit()
        {
            _DbContext.SaveChanges();
        }
    }
}
