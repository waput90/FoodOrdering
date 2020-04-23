﻿// <auto-generated />
using System;
using FoodOrdering.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodOrdering.Data.Migrations.FoodOrderingDb
{
    [DbContext(typeof(FoodOrderingDbContext))]
    [Migration("20200423095029_addMenuSeed")]
    partial class addMenuSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            DateRegistered = new DateTime(2020, 4, 23, 9, 50, 28, 337, DateTimeKind.Utc).AddTicks(2644),
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
                            DateCreated = new DateTime(2020, 4, 23, 9, 50, 28, 340, DateTimeKind.Utc).AddTicks(3910),
                            Description = "Burger menu",
                            Name = "Burgers"
                        },
                        new
                        {
                            Id = "abb6df87-2b3f-4151-941e-76ed546b8caa",
                            DateCreated = new DateTime(2020, 4, 23, 9, 50, 28, 340, DateTimeKind.Utc).AddTicks(5290),
                            Description = "Beverages menu",
                            Name = "Beverages"
                        },
                        new
                        {
                            Id = "f1c48325-b4b2-401c-9dae-c03bc4980b0e",
                            DateCreated = new DateTime(2020, 4, 23, 9, 50, 28, 340, DateTimeKind.Utc).AddTicks(5331),
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
