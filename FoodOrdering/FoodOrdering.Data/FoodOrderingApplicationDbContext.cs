using FoodOrdering.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodOrdering.Data
{
    public class FoodOrderingApplicationDbContext: IdentityDbContext<SystemUser>
    {
        public FoodOrderingApplicationDbContext(DbContextOptions<FoodOrderingApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}