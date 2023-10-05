using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
                .HasData(
                        new Product { ProductId = 1, ProductName = "Computer", Price = 17000 },
                        new Product { ProductId = 2, ProductName = "Keyboard", Price = 1000 },
                        new Product { ProductId = 3, ProductName = "Mouse", Price = 600 },
                        new Product { ProductId = 4, ProductName = "Monitor", Price = 8000 },
                        new Product { ProductId = 5, ProductName = "Deck", Price = 1500 }
                 );
            modelBuilder.Entity<Category>()
                .HasData(
                new Category { CategoryId=1,CategoryName="Books"},
                new Category { CategoryId=2,CategoryName="Electronics"}
                );
        }
    }
}
