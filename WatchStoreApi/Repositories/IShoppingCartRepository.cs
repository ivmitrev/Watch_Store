using WatchStoreApi.Dtos;
using WatchStoreApi.Models;

namespace WatchStoreApi.Repositories;

public interface IShoppingCartRepository
{
    Task<CartItem> AddProduct(CartProductToAddDto cartProductToAddDto);
    Task<CartItem> UpdateQuantity(int id, CartProductQuantityUpdateDto cartProductQuantityUpdateDto);
    Task<CartItem> DeleteProduct(int id);
    Task<CartItem> GetProduct(int id);
    Task<IEnumerable<CartItem>> GetProducts();
}