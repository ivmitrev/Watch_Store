using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WatchStoreApi.Data;
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
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        if (product == null)
        {
           // return NotFound();
        }

        return product;
    }

    public async Task<ProductCategory> GetCategory(int id)
    {
        var category = await _dbContext.ProductCategories.FirstOrDefaultAsync(x => x.Id == id);
        if (category == null)
        {
            // return NotFound();
        }
        return category;
    }
}