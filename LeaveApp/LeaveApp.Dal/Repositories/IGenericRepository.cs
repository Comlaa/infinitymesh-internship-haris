using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Repositories
{
    interface IGenericRepository<TEntitity> where TEntitity : BaseEntitity
    {
        TEntitity getByID(int ID);
        IEnumerable<TEntitity> GetAllObjects();
        TEntitity AddObject(TEntitity obj);
        void RemoveObjectByID(int ID);

    }
}
