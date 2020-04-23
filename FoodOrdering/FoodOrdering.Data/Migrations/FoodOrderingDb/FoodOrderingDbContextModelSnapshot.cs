﻿// <auto-generated />
using System;
using FoodOrdering.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodOrdering.Data.Migrations.FoodOrderingDb
{
    [DbContext(typeof(FoodOrderingDbContext))]
    partial class FoodOrderingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("FoodOrdering.Data.Models.Coupon", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(80);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<int>("Discount");

                    b.Property<bool?>("IsUsed");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.Property<DateTime>("Validity");

                    b.HasKey("Id");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            Id = "6a06d7c6-6cac-46b7-8581-2a93f0b17c1b",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(7518),
                            Description = "Lucky coupon for 2018",
                            Discount = 10,
                            Name = "GO2018",
                            NormalizedName = "GO2018",
                            Validity = new DateTime(2021, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(7172)
                        });
                });

            modelBuilder.Entity("FoodOrdering.Data.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(80);

                    b.Property<DateTime>("DateRegistered");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = "57b8d303-e29e-4433-8cb7-3d2f24a8e26e",
                            DateRegistered = new DateTime(2020, 4, 23, 10, 39, 38, 831, DateTimeKind.Utc).AddTicks(1300),
                            Email = "james@example.com",
                            FirstName = "James",
                            LastName = "Anonymous"
                        });
                });

            modelBuilder.Entity("FoodOrdering.Data.Models.CustomerOrder", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(80);

                    b.Property<string>("CouponId");

                    b.Property<string>("CustomerId")
                        .HasMaxLength(80);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("ProductId")
                        .HasMaxLength(80);

                    b.Property<int>("Qty");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerOrders");
                });

            modelBuilder.Entity("FoodOrdering.Data.Models.Menu", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(80);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = "43692e17-12bb-4cd7-b688-b0a97d3188df",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(1800),
                            Description = "Burger menu",
                            Name = "Burgers"
                        },
                        new
                        {
                            Id = "abb6df87-2b3f-4151-941e-76ed546b8caa",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(2467),
                            Description = "Beverages menu",
                            Name = "Beverages"
                        },
                        new
                        {
                            Id = "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(2490),
                            Description = "Combo meals menu",
                            Name = "Combo Meals"
                        });
                });

            modelBuilder.Entity("FoodOrdering.Data.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(80);

                    b.Property<string>("CustomerId")
                        .HasMaxLength(80);

                    b.Property<decimal>("DiscountedTotal");

                    b.Property<DateTime>("OrderDate");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FoodOrdering.Data.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(80);

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("MenuId")
                        .HasMaxLength(80);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "372e1e02-9777-4781-81ce-3a6f6d793f85",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(4645),
                            Description = "Very delicious hotdog",
                            MenuId = "43692e17-12bb-4cd7-b688-b0a97d3188df",
                            Name = "Hotdog",
                            Price = 15.00m
                        },
                        new
                        {
                            Id = "59e94b90-76e9-42ab-9c3c-6c8121d0f303",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5231),
                            Description = "Bun with cheese filling",
                            MenuId = "43692e17-12bb-4cd7-b688-b0a97d3188df",
                            Name = "CheeseBurger",
                            Price = 75.00m
                        },
                        new
                        {
                            Id = "5bcbd116-bd35-44b8-a16e-f7cee41ce669",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5255),
                            Description = "Potato fried fries",
                            MenuId = "43692e17-12bb-4cd7-b688-b0a97d3188df",
                            Name = "French Fries",
                            Price = 60.00m
                        },
                        new
                        {
                            Id = "ef485769-1125-499a-b816-35ca59505d82",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5268),
                            Description = "Coca cola",
                            MenuId = "abb6df87-2b3f-4151-941e-76ed546b8caa",
                            Name = "Coke",
                            Price = 25.00m
                        },
                        new
                        {
                            Id = "b09869b7-4c60-4ccf-a890-fbcfc209b763",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5279),
                            Description = "Cold Sprite",
                            MenuId = "abb6df87-2b3f-4151-941e-76ed546b8caa",
                            Name = "Sprite",
                            Price = 23.00m
                        },
                        new
                        {
                            Id = "ce9f0db6-6f15-42ed-be33-d1c26c4a8842",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5298),
                            Description = "Cold Tea",
                            MenuId = "abb6df87-2b3f-4151-941e-76ed546b8caa",
                            Name = "Iced Tea",
                            Price = 20.00m
                        },
                        new
                        {
                            Id = "2487dc90-94da-4fcc-a258-6875119aae8d",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5308),
                            Description = "1pc chicken with coke",
                            MenuId = "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                            Name = "Chicken Combo Meal",
                            Price = 104.00m
                        },
                        new
                        {
                            Id = "1c39961e-8bfb-4ef7-a923-7e1da1b5c544",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5319),
                            Description = "1pc pork with ice tea/coke",
                            MenuId = "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                            Name = "Pork Combo",
                            Price = 125.00m
                        },
                        new
                        {
                            Id = "8482fa30-d72b-4ba5-9ac5-c72359c9a2c9",
                            DateCreated = new DateTime(2020, 4, 23, 10, 39, 38, 833, DateTimeKind.Utc).AddTicks(5331),
                            Description = "1pc fish fillet with sprite",
                            MenuId = "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                            Name = "Fish Combo",
                            Price = 155.00m
                        });
                });

            modelBuilder.Entity("FoodOrdering.Data.Models.CustomerOrder", b =>
                {
                    b.HasOne("FoodOrdering.Data.Models.Customer", "SystemUser")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("FoodOrdering.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("FoodOrdering.Data.Models.Menu", b =>
                {
                    b.HasOne("FoodOrdering.Data.Models.Product")
                        .WithMany("Menus")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("FoodOrdering.Data.Models.Order", b =>
                {
                    b.HasOne("FoodOrdering.Data.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("FoodOrdering.Data.Models.Product", b =>
                {
                    b.HasOne("FoodOrdering.Data.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId");
                });
#pragma warning restore 612, 618
        }
    }
}
