using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Repositories
{
    interface IGenericRepository<T>
    {
        T getByID(T ID);
        IEnumerable<T> GetAllObjects();
        void AddObject(T ID);
        void RemoveObject(T ID);

    }
}
