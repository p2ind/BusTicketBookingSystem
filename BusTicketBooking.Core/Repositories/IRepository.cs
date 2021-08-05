using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketBooking.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
