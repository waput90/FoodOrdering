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
    [Migration("20200421144539_menuPrimaryKey")]
    partial class menuPrimaryKey
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

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.Property<DateTime>("Validity");

                    b.HasKey("Id");

                    b.ToTable("Coupons");
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

            modelBuilder.Entity("FoodOrdering.Data.Models.Menu", b =>
                {
                    b.HasOne("FoodOrdering.Data.Models.Product")
                        .WithMany("Menus")
                        .HasForeignKey("ProductId");
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
