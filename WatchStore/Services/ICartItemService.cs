using WatchStoreApi.Dtos;

namespace WatchStore.Services;

public interface ICartItemService
{
    Task<IEnumerable<CartItemDto>> GetCartItems();
    Task<CartItemDto> GetCartItem(int id);
    Task<CartItemDto> AddCartItem(CartItemToAddDto cartItemToAddDto);
    Task<CartItemDto> DeleteCartItem(int id);
    Task<CartItemDto> UpdateCartItemQuantity(int id, CartItemQuantityUpdateDto cartItemQuantityUpdateDto);
    Task<string> Checkout();    
}