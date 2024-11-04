using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WatchStoreApi.Data;
using WatchStoreApi.Dtos;
using WatchStoreApi.Models;

namespace WatchStoreApi.Repositories;

public class CartRepository : ICartRepository
{
    private readonly WatchStoreDbContext _dbContext;

    public CartRepository(WatchStoreDbContext _dbContext)
    {
        this._dbContext = _dbContext;
    }

    public async Task<bool> CartItemIsAlreadyAdded(int productId)
    {
        return await _dbContext.CartItems.AnyAsync(x => x.ProductId == productId);
    }
    public async Task<CartItem> AddCartItem(CartItem cartItem)
    {
        if (await CartItemIsAlreadyAdded(cartItem.Id) == false)
        {
            if (cartItem == null)
            {
                return cartItem;
            }

            await _dbContext.CartItems.AddAsync(cartItem);
            await _dbContext.SaveChangesAsync();
            return cartItem;
        }

        return null;
    }

    public async Task<CartItem> UpdateQuantity(int id, CartItem cartItem)
    {
        var cartItemNew = await _dbContext.CartItems.FindAsync(id);
        if (cartItemNew == null)
        {
            return null;
        }

        cartItemNew.ProductId = cartItem.ProductId;
        cartItemNew.Quantity = cartItem.Quantity;

        await _dbContext.SaveChangesAsync();
        return cartItemNew;
    }

    public async Task<CartItem> DeleteCartItem(int id)
    {
        var cartItem = await _dbContext.CartItems.FindAsync(id);
        if (cartItem == null)
        {
            return cartItem;
        }

        _dbContext.CartItems.Remove(cartItem);
        await _dbContext.SaveChangesAsync();
        return cartItem;
    }

    public async Task<CartItem> GetCartItem(int id)
    {
        var cartItem = await _dbContext.CartItems.FindAsync(id);
        return cartItem;     
    }

    public async Task<IEnumerable<CartItem>> GetCartItems()
    {
        var cartItems = await _dbContext.CartItems.ToListAsync();
        return cartItems;
    }
}