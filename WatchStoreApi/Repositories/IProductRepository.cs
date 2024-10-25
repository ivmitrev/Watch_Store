using WatchStoreApi.Models;

namespace WatchStoreApi.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProducts();
    Task<IEnumerable<ProductCategory>> GetCategories();
    Task<Product> GetItem(int id);
    Task<ProductCategory> GetCategory(int id);
} 