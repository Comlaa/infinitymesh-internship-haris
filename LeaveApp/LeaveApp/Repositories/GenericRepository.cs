using LeaveApp.Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private LeaveAppDbContext _Context = null;
        private DbSet<T> Table = null;

        public GenericRepository(LeaveAppDbContext context)
        {
            _Context = context;
            Table = _Context.Set<T>();
        }
        public void AddObject(T obj)
        {
            Table.Add(obj);
        }

        public IEnumerable<T> GetAllObjects()
        {
            return Table.ToList();
        }

        public T getByID(object ID)
        {
            return Table.Find(ID);
        }

        public void RemoveObjectByID(object ID)
        {
            T Obj = Table.Find(ID);
            Table.Remove(Obj);

        }
    }
}
