using FoodOrdering.Data.Access.Patterns.Uow;

namespace FoodOrdering.Data.Access.Patterns.Factory
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork CreateUow(bool trackChanges = true, bool enableLogging = false);
    }
}