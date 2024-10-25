using Microsoft.EntityFrameworkCore;
using WatchStoreApi.Models;

namespace WatchStoreApi.Data;

public class WatchStoreDbContext : DbContext
{
    
    public WatchStoreDbContext(DbContextOptions<WatchStoreDbContext> options)
        : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 1,
                Name = "Rolex Datejust 36",
                Description = "Oyster, 36 mm, Oystersteel and white gold",
                Price = 18500,
                Image = "/Images/Rolex/datejust36.png",
                Quantity = 5,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 2,
                Name = "Rolex Submariner 41",
                Description = "Oyster, 41 mm, Oystersteel",
                Price = 18300,
                Image = "/Images/Rolex/submariner41.png",
                Quantity = 7,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory()
            {
                Id = 1,
                Name = "Rolex"
            }
        );
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory()
            {
                Id = 2,
                Name = "Hublot"
            }
        );
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory()
            {
                Id = 3,
                Name = "Patek Philippe"
            }
        );
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory()
            {
                Id = 4,
                Name = "Breitling"
            }
        );
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory()
            {
                Id = 5,
                Name = "Tissot"
            }
        );
        modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory()
            {
                Id = 6,
                Name = "Omega"
            }
        );
       

    }

    
    public DbSet<Product> Products{ get; set; }
    public DbSet<ProductCategory> ProductCategories{ get; set; }
}