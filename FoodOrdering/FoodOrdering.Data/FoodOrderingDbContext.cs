using System;
using FoodOrdering.Commons.Extensions;
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
            modelBuilder.Entity<Product>(entity => entity.Property(m => m.MenuId).HasMaxLength(80));
            modelBuilder.Entity<Product>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<Coupon>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<CustomerOrder>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<CustomerOrder>(entity => entity.Property(m => m.CustomerId).HasMaxLength(80));
            modelBuilder.Entity<CustomerOrder>(entity => entity.Property(m => m.ProductId).HasMaxLength(80));
            modelBuilder.Entity<Order>(entity => entity.Property(m => m.Id).HasMaxLength(80));
            modelBuilder.Entity<Order>(entity => entity.Property(m => m.CustomerId).HasMaxLength(80));
            modelBuilder.Entity<Customer>(entity => entity.Property(m => m.Id).HasMaxLength(80));

            #region Customer

            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                FirstName = "James",
                LastName = "Anonymous",
                Email = "james@example.com",
                DateRegistered = DateTime.Now.GetDate()
            });

            #endregion

            #region Menu 

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                Id = "43692e17-12bb-4cd7-b688-b0a97d3188df",
                Name = "Burgers",
                Description = "Burger menu",
                DateCreated = DateTime.Now.GetDate()
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                Id = "abb6df87-2b3f-4151-941e-76ed546b8caa",
                Name = "Beverages",
                Description = "Beverages menu",
                DateCreated = DateTime.Now.GetDate()
            });

            modelBuilder.Entity<Menu>().HasData(new Menu
            {
                Id = "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                Name = "Combo Meals",
                Description = "Combo meals menu",
                DateCreated = DateTime.Now.GetDate()
            });

            #endregion

            #region Products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = "372e1e02-9777-4781-81ce-3a6f6d793f85",
                MenuId = "43692e17-12bb-4cd7-b688-b0a97d3188df",
                Name = "Hotdog",
                Description = "Very delicious hotdog",
                Price = 15.00M,
                DateCreated = DateTime.Now.GetDate()
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = "59e94b90-76e9-42ab-9c3c-6c8121d0f303",
                MenuId = "43692e17-12bb-4cd7-b688-b0a97d3188df",
                Name = "CheeseBurger",
                Description = "Bun with cheese filling",
                Price = 75.00M,
                DateCreated = DateTime.Now.GetDate()
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = "5bcbd116-bd35-44b8-a16e-f7cee41ce669",
                MenuId = "43692e17-12bb-4cd7-b688-b0a97d3188df",
                Name = "French Fries",
                Description = "Potato fried fries",
                Price = 60.00M,
                DateCreated = DateTime.Now.GetDate()
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = "ef485769-1125-499a-b816-35ca59505d82",
                MenuId = "abb6df87-2b3f-4151-941e-76ed546b8caa",
                Name = "Coke",
                Description = "Coca cola",
                Price = 25.00M,
                DateCreated = DateTime.Now.GetDate()
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = "b09869b7-4c60-4ccf-a890-fbcfc209b763",
                MenuId = "abb6df87-2b3f-4151-941e-76ed546b8caa",
                Name = "Sprite",
                Description = "Cold Sprite",
                Price = 23.00M,
                DateCreated = DateTime.Now.GetDate()
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = "ce9f0db6-6f15-42ed-be33-d1c26c4a8842",
                MenuId = "abb6df87-2b3f-4151-941e-76ed546b8caa",
                Name = "Iced Tea",
                Description = "Cold Tea",
                Price = 20.00M,
                DateCreated = DateTime.Now.GetDate()
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = "2487dc90-94da-4fcc-a258-6875119aae8d",
                MenuId = "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                Name = "Chicken Combo Meal",
                Description = "1pc chicken with coke",
                Price = 104.00M,
                DateCreated = DateTime.Now.GetDate()
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = "1c39961e-8bfb-4ef7-a923-7e1da1b5c544",
                MenuId = "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                Name = "Pork Combo",
                Description = "1pc pork with ice tea/coke",
                Price = 125.00M,
                DateCreated = DateTime.Now.GetDate()
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = "8482fa30-d72b-4ba5-9ac5-c72359c9a2c9",
                MenuId = "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                Name = "Fish Combo",
                Description = "1pc fish fillet with sprite",
                Price = 155.00M,
                DateCreated = DateTime.Now.GetDate()
            });

            #endregion

            #region Coupon

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                Id = "6a06d7c6-6cac-46b7-8581-2a93f0b17c1b",
                Name = "GO2018",
                NormalizedName = "GO2018",
                Discount = 10,
                Description = "Lucky coupon for 2018",
                Validity = DateTime.Now.GetDate().AddYears(1),
                DateCreated = DateTime.Now.GetDate(),
            });

            #endregion
        }

        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Coupon> Coupons { get; set; }
        public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
