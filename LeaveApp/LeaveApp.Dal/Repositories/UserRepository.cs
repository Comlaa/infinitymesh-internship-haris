using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace LeaveApp.Dal.Repositories
{
    class UserRepository : GenericRepository<User>
    {
        public UserRepository(LeaveAppDbContext _Context) : base(_Context)
        {

        }
    }
}
