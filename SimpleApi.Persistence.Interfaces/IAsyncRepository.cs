using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApi.Persistence.Interfaces
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task DeleteAsync(string id);
        Task<T> GetByIdAsync(string id);
        IQueryable<T> ListAllAsync();
        Task UpdateAsync(T entity);
    }
}
