using WatchStoreApi.Dtos;
using WatchStoreApi.Models;

namespace WatchStoreApi.Repositories;

public class ShoppingCartRepository : IShoppingCartRepository
{
    public Task<CartItem> AddProduct(CartProductToAddDto cartProductToAddDto)
    {
        throw new NotImplementedException();
    }

    public Task<CartItem> UpdateQuantity(int id, CartProductQuantityUpdateDto cartProductQuantityUpdateDto)
    {
        throw new NotImplementedException();
    }

    public Task<CartItem> DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CartItem> GetProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CartItem>> GetProducts()
    {
        throw new NotImplementedException();
    }
}