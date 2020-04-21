using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FoodOrdering.Data.Access.Patterns.Repository
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> FindAsync(params object[] keyValues);
        Task<IEnumerable<TEntity>> ItemsWithAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<IEnumerable<TEntity>> ItemsAsync(Expression<Func<TEntity, bool>> predicate = null);
        void Insert(TEntity newItem);
        void InsertBulk(IEnumerable<TEntity> newItems);
        void Update(TEntity item, params Expression<Func<TEntity, object>>[] excludeProperties);
        void Delete(TEntity item);
        void Delete(object itemId);
        void DeleteBulk(IEnumerable<TEntity> itemsToDelete);
    }
}