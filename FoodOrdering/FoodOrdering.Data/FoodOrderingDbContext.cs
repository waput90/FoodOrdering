using FoodOrdering.Data.Access;
using FoodOrdering.Data.Models;
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
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Menu>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<Menu>(entity => entity.Property(m => m.ProductId).HasMaxLength(80));
            modelBuilder.Entity<Product>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<Coupon>(entity => entity.Property(m => m.Id).HasMaxLength(80));
        }

        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
    }
}
