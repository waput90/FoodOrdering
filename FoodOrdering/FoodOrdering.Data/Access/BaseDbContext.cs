using Microsoft.EntityFrameworkCore;

namespace FoodOrdering.Data.Access
{
    public abstract class BaseDbContext<T> : DbContext, IDbContext where T : DbContext
    {
        protected BaseDbContext(DbContextOptions<T> contextOptions) : base(contextOptions)
        {

        }
    }
}