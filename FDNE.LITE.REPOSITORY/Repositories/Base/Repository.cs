using FDNE.LITE.DATA.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FDNE.LITE.REPOSITORY.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly FdneContext _context;
        private readonly DbSet<T> _entities;

        public Repository(FdneContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }


        public async Task<bool> Any(Guid id)
        {
            var entity = await _entities.FindAsync(id);
            return entity != null;
        }

        public async Task<bool> Any(string id)
        {
            var entity = await _entities.FindAsync(id);
            return entity != null;
        }

        public async Task<int> Count() => await _entities.CountAsync();

        public async Task<T> First() => await _entities.FirstOrDefaultAsync();

        public async Task<T> Last() => await _entities.LastOrDefaultAsync();

        public virtual async Task<T> Get(Guid id) => await _entities.FindAsync(id);

        public virtual async Task<T> Get(string id) => await _entities.FindAsync(id);

        public virtual async Task<IEnumerable<T>> GetAll() => await _entities.AsQueryable().ToListAsync();

        public virtual async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> where)
            => await _entities.Where(where).ToListAsync();

        public virtual async Task<IEnumerable<TType>> GetAll<TType>(Expression<Func<T, bool>> where, Expression<Func<T, TType>> select) where TType : class
            => await _entities.Where(where).Select(select).ToListAsync();

        public async Task<T> Add(T entity)
        {
            var result = await _entities.AddAsync(entity);
            return result.Entity;
        }

        public virtual async Task Delete(T entity)
        {
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteById(Guid id)
        {
            var entity = await this.Get(id);
            await Delete(entity);
        }

        public virtual async Task DeleteById(string id)
        {
            var entity = await this.Get(id);
            await Delete(entity);
        }

        public async Task DeleteRange(IEnumerable<T> entities)
        {
            _entities.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Insert(T entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _entities.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                // Should call Dispose() to remove the elements from the failed context?
                throw new ArgumentNullException(nameof(entity));
            }

            await _context.SaveChangesAsync();
        }

        public async Task UpdateRange(IEnumerable<T> entities)
        {
            if (entities != null)
            {
                await _context.SaveChangesAsync();
            }
        }
    }
        
}
