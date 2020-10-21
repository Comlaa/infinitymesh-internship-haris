using LeaveApp.Dal;
using LeaveApp.Dal.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Repositories
{
    public class GenericRepository<TEntitity> : IGenericRepository<TEntitity> where TEntitity : BaseEntitity
    {
        private LeaveAppDbContext _Context = null;
        private DbSet<TEntitity> Table = null;

        public GenericRepository(LeaveAppDbContext context)
        {
            _Context = context;
            Table = _Context.Set<TEntitity>();
        }
        public TEntitity AddObject(TEntitity obj)
        {
            Table.Add(obj);
            return obj;
        }

        public IEnumerable<TEntitity> GetAllObjects()
        {
            return Table.ToList();
        }

        public TEntitity getByID(int ID)
        {
            return Table.Find(ID);
        }

        public void RemoveObjectByID(int ID)
        {
            TEntitity Obj = Table.Find(ID);
            Table.Remove(Obj);

        }
    }
}
