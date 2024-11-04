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
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 12,
                Name = "Unico Yellow Magic 44",
                Description = "Big Bang, 44 mm, Polished Yellow Ceramic, Rubber Strap",
                Price = 61600,
                Image = "/Images/Hublot/hublot12.png",
                Quantity = 4,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 13,
                Name = "Chronograph Black Magic 42",
                Description = "Classic Fusion, 42 mm, Polished Black Ceramic, Rubber Strap",
                Price = 25600,
                Image = "/Images/Hublot/hublot1.png",
                Quantity = 8,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 14,
                Name = "Original Steel Ceramic 44",
                Description = "Big Band, 44 mm, Stainless Steel, Black Rubber Strap",
                Price = 30400,
                Image = "/Images/Hublot/hublot2.png",
                Quantity = 2,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 15,
                Name = "Unico Ice Bang 42",
                Description = "Big Bang, 42 mm, Microblasted Black Ceramic, Black Fabric and Black Ceramic Buckle",
                Price = 50000,
                Image = "/Images/Hublot/hublot3.png",
                Quantity = 11,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 16,
                Name = "Tourbillon Sorai 42",
                Description = "Tourbillon, 42 mm, Satin-finished and Polished Titanium, Sapphire with Anti-reflective Treatment",
                Price = 230000,
                Image = "/Images/Hublot/hublot4.png",
                Quantity = 1,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 17,
                Name = "Integrated Time Only Titanium 38",
                Description = "Big Bang, 38 mm, Microblasted Black Ceramic, Black ceramic and Black Titane Deployant Buckle",
                Price = 27200,
                Image = "/Images/Hublot/hublot5.png",
                Quantity = 4,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 18,
                Name = "Big Bang Steel Blue 44",
                Description = "Big Bang, 44 mm, Polished and Satin-finished Stainless Steel, Blue Straps",
                Price = 28200,
                Image = "/Images/Hublot/hublot6.png",
                Quantity = 3,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 19,
                Name = "Big Bang Gold Blue 44",
                Description = "Big Bang, 44 mm, Polished and Satin-finished 18k 5N Gold, Blue Straps",
                Price = 75200,
                Image = "/Images/Hublot/hublot7.png",
                Quantity = 7,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 20,
                Name = "Classic Fusion 42",
                Description = "Racing Grey Chronograph Titanium, 42 mm, Satin-finished Titanium, Gray Straps",
                Price = 23400,
                Image = "/Images/Hublot/hublot8.png",
                Quantity = 11,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 21,
                Name = "Classic Fusion Gold 38",
                Description = "Original Yellow Gold, 38 mm, Black Straps",
                Price = 44600,
                Image = "/Images/Hublot/hublot9.png",
                Quantity = 2,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 22,
                Name = "Classic Fusion Green 42",
                Description = "Chronograph Titanium Green, 42 mm, Satin-finished Titanium, Green Straps",
                Price = 22000,
                Image = "/Images/Hublot/hublot10.png",
                Quantity = 8,
                CategoryId = 2
            }
        );
        modelBuilder.Entity<Product>().HasData(new Product()
            {
                Id = 23,
                Name = "Unico Ceramic Loon 42",
                Description = "Square Bang Gold, 42 mm, Black Straps",
                Price = 66000,
                Image = "/Images/Hublot/hublot11.png",
                Quantity = 5,
                CategoryId = 2
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

    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Product> Products{ get; set; }
    public DbSet<ProductCategory> ProductCategories{ get; set; }
}