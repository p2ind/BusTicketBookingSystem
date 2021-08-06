using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketBooking.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Find(object id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Object id);

        void Remove(TEntity entity);

        int SaveChanges(); 
    }
}
