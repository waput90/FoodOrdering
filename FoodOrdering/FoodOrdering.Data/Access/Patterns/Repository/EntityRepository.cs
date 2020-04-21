using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FoodOrdering.Data.Access.Common;

namespace FoodOrdering.Data.Access.Patterns.Repository
{
    public sealed class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly object _sync = new object();
        private readonly DbContext _dbContext;

        public EntityRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity> FindAsync(params object[] keyValues)
        {
            return await _dbContext.Set<TEntity>().FindAsync(keyValues);
        }

        public async Task<IEnumerable<TEntity>> ItemsWithAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            lock (_sync)
            {
                IQueryable<TEntity> query = null;

                if (predicate != null)
                    query = _dbContext.Set<TEntity>().Where(predicate);
                else
                    query = _dbContext.Set<TEntity>();

                foreach (var includeProperty in includeProperties)
                    query = query.Include(includeProperty);

                return query.ToArray();
            }
        }

        public async Task<IEnumerable<TEntity>> ItemsAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate != null)
                return _dbContext.Set<TEntity>().Where(predicate).ToArray();
            else
                return _dbContext.Set<TEntity>().ToArray();
        }

        public void Insert(TEntity newItem)
        {
            _dbContext.Set<TEntity>().Add(newItem);
        }

        public void InsertBulk(IEnumerable<TEntity> newItems)
        {
            _dbContext.Set<TEntity>().AddRange(newItems);
        }

        public void Update(TEntity item, params Expression<Func<TEntity, object>>[] excludeProperties)
        {
            _dbContext.Set<TEntity>().Attach(item);

            var entry = _dbContext.Entry(item);
            entry.State = EntityState.Modified;

            excludeProperties.ToList().ForEach(excludeProperty =>
            {
                entry.Property(excludeProperty).IsModified = false;
            });
        }

        public void Delete(TEntity item)
        {
            _dbContext.Entry(item).State = EntityState.Deleted;
        }

        public void Delete(object id)
        {
            var item = _dbContext.Set<TEntity>().Find(id);
            if (item != null)
                _dbContext.Set<TEntity>().Remove(item);
        }

        public void DeleteBulk(IEnumerable<TEntity> itemsToDelete)
        {
            _dbContext.Set<TEntity>().RemoveRange(itemsToDelete);
        }
    }
}