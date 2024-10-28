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
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 3,
                Name = "Rolex GMT-MASTER II",
                Description = "Oyster, 40 mm, Oystersteel",
                Price = 21650,
                Image = "/Images/Rolex/gmt-master2.png",
                Quantity = 4,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 4,
                Name = "Rolex Day-Date 40",
                Description = "Oyster, 40 mm, Everose gold",
                Price = 87300,
                Image = "/Images/Rolex/daydate40.png",
                Quantity = 3,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 5,
                Name = "Rolex Cosmograph Daytona",
                Description = "Oyster, 40 mm, white gold",
                Price = 89500,
                Image = "/Images/Rolex/daytonaCosmo.png",
                Quantity = 1,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 6,
                Name = "Rolex Oyster Perpetual 41",
                Description = "Oyster, 41 mm, Oystersteel",
                Price = 12850,
                Image = "/Images/Rolex/perpetual41.png",
                Quantity = 4,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 7,
                Name = "Rolex YachtMaster 42",
                Description = "Oyster, 42 mm, RLX titanium",
                Price = 28450,
                Image = "/Images/Rolex/yachmaster42.png",
                Quantity = 10,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 8,
                Name = "Rolex Sea-Dweller",
                Description = "Oyster, 43 mm, Oystersteel and yellow gold",
                Price = 38000,
                Image = "/Images/Rolex/seadweller43.png",
                Quantity = 6,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 9,
                Name = "Rolex Deepsea",
                Description = "Oyster, 44 mm, yellow gold",
                Price = 109600,
                Image = "/Images/Rolex/deepsea44.png",
                Quantity = 1,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 10,
                Name = "Rolex Air-King",
                Description = "Oyster, 40 mm, Oystersteel",
                Price = 14950,
                Image = "/Images/Rolex/airking40.png",
                Quantity = 11,
                CategoryId = 1
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 11,
                Name = "Rolex Explorer 36",
                Description = "Oyster, 36 mm, Oystersteel and yellow gold",
                Price = 24800,
                Image = "/Images/Rolex/explorer36.png",
                Quantity = 18,
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