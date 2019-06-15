using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FDNE.LITE.REPOSITORY.Repositories.Base
{
    public interface IRepository<T>
    {
        Task<bool> Any(Guid id);
        Task<bool> Any(string id);
        Task<int> Count();
        Task<T> First();
        Task<T> Last();
        Task<T> Get(Guid id);
        Task<T> Get(string id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        Task Delete(T entity);
        Task DeleteById(Guid id);
        Task DeleteById(string id);
        Task DeleteRange(IEnumerable<T> entities);
        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entities);
        Task Update(T entity);
        Task UpdateRange(IEnumerable<T> entities);
    }
}
