using System;
using FoodOrdering.Data.Access;
using Microsoft.EntityFrameworkCore;

namespace FoodOrdering.Data
{
    public class FoodOrderingDbContext : BaseDbContext<FoodOrderingDbContext>
    {
        public FoodOrderingDbContext(DbContextOptions<FoodOrderingDbContext> contextOptions) : base(contextOptions)
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
