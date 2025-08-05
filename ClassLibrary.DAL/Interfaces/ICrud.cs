using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerApi.DAL.Interfaces
{
    public interface ICrud<T>
    {
        Task<T> CreateAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
