using System;
using System.Threading.Tasks;
using FoodOrdering.Data.Access.Common;
using FoodOrdering.Data.Access.Patterns.Repository;

namespace FoodOrdering.Data.Access.Patterns.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetEntityRepository<TEntity>()
            where TEntity : class, IEntity,
            new();

        Task Commit();
    }
}