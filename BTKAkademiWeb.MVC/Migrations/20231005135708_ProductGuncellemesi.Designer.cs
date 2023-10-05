﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace BTKAkademiWeb.MVC.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231005135708_ProductGuncellemesi")]
    partial class ProductGuncellemesi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Book"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Electronic"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2,
                            Price = 17000m,
                            ProductName = "Computer",
                            Summary = ""
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            Price = 1000m,
                            ProductName = "Keyboard",
                            Summary = ""
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Price = 500m,
                            ProductName = "Mouse",
                            Summary = ""
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Price = 7000m,
                            ProductName = "Monitor",
                            Summary = ""
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Price = 1500m,
                            ProductName = "Deck",
                            Summary = ""
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            Price = 25m,
                            ProductName = "History",
                            Summary = ""
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            Price = 45m,
                            ProductName = "Hamlet",
                            Summary = ""
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.HasOne("Entities.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}