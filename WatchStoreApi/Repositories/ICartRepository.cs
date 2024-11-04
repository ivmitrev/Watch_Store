using WatchStoreApi.Dtos;
using WatchStoreApi.Models;

namespace WatchStoreApi.Repositories;

public interface ICartRepository
{
    Task<CartItem> AddCartItem(CartItem cartItem);
    Task<CartItem> UpdateQuantity(int id, CartItem cartItem);
    Task<CartItem> DeleteCartItem(int id);
    Task<CartItem> GetCartItem(int id);
    Task<IEnumerable<CartItem>> GetCartItems();
}