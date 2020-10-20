using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Repositories
{
    interface IGenericRepository<T> where T : class
    {
        T getByID(object ID);
        IEnumerable<T> GetAllObjects();
        void AddObject(T obj);
        void RemoveObjectByID(object ID);

    }
}
