using LeaveApp.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private static DBContext _DBContext = new DBContext();
        public void AddObject(T ID)
        {
            
        }

        public IEnumerable<T> GetAllObjects()
        {
            throw new NotImplementedException();
        }

        public T getByID(T ID)
        {
            throw new NotImplementedException();
        }

        public void RemoveObject(T ID)
        {
            throw new NotImplementedException();
        }
    }
}
