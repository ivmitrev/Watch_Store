using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WatchStoreApi.Data;
using WatchStoreApi.Dtos;
using WatchStoreApi.Models;

namespace WatchStoreApi.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly WatchStoreDbContext _dbContext;
    public ProductRepository(WatchStoreDbContext dbContext)
    {
        this._dbContext = dbContext;
    }
    
    
    public async Task<IEnumerable<Product>> GetProducts()
    {
        var products = await _dbContext.Products.ToListAsync();
        return products;
    }

    public async Task<IEnumerable<ProductCategory>> GetCategories()
    {
        var categories = await _dbContext.ProductCategories.ToListAsync();
        return categories;
    }

    public async Task<Product> GetItem(int id)
    {
        var product = await _dbContext.Products.FindAsync(id);
        return product;
    }

    public async Task<ProductCategory> GetCategory(int id)
    {
        var category = await _dbContext.ProductCategories.SingleOrDefaultAsync(x => x.Id == id);
        return category;
    }

    public async Task<Product> CreateProduct(Product product)
    {
        await _dbContext.Products.AddAsync(product);
        await _dbContext.SaveChangesAsync();
        return product;
    }

    public async Task<Product> DeleteProduct(int id)
    {
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        if (product == null)
        {
            return null;
        }

        _dbContext.Products.Remove(product);
        await _dbContext.SaveChangesAsync();
        return product;
    }

    public async Task<Product> UpdateProduct(int id, Product productUpdate)
    {
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        if (product == null)
        {
            return null;
        }

        product.Name = productUpdate.Name;
        product.Description = productUpdate.Description;
        product.Price = productUpdate.Price;
        product.Image = productUpdate.Image;
        product.Quantity = productUpdate.Quantity;
        product.CategoryId = productUpdate.CategoryId;
        
        await _dbContext.SaveChangesAsync();
        return product;
    }
}