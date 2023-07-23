using LemondropsCafe.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LemondropsCafe.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int T);
        Task AddAsync(T menuItem);
        Task UpdateAsync(int id, T entity);
        Task Delete(int id);
    }
}
