using LeaveApp.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeaveApp.Dal.Repositories
{
    public interface IGenericRepository<TEntitity> where TEntitity : BaseEntitity
    {
        TEntitity getById(int Id);
        Task<IReadOnlyCollection<TEntitity>> GetTopTen(CancellationToken cancellationToken = default);
        TEntitity AddObject(TEntitity obj);
        void DeleteById(int Id);

    }
}
