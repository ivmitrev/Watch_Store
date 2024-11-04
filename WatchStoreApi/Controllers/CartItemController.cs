using Microsoft.AspNetCore.Mvc;
using WatchStoreApi.Dtos;
using WatchStoreApi.Extensions;
using WatchStoreApi.Models;
using WatchStoreApi.Repositories;

namespace WatchStoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CartItemController : ControllerBase
{
    private readonly ICartRepository _iCartRepository;
    private readonly IProductRepository _iProductRepository;

    public CartItemController(ICartRepository _iCartRepository, IProductRepository _iProductRepository)
    {
        this._iCartRepository = _iCartRepository;
        this._iProductRepository = _iProductRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CartItemDto>>> GetCartItems()
    {
        var cartItems = await _iCartRepository.GetCartItems();
        if (cartItems == null)
        {
            return NotFound();
        }
        else
        {
            var products = await _iProductRepository.GetProducts();
            if (products == null)
            {
                return NotFound();
            }

            var cartItemDtos = cartItems.FromCartItemToCartItemDtos(products);
            return Ok(cartItemDtos);
        }
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<CartItemDto>> GetCartItem(int id)
    {
        var cartItem = await _iCartRepository.GetCartItem(id);
        if (cartItem == null)
        {
            return BadRequest();
        }
        else
        {
            var product = await _iProductRepository.GetItem(cartItem.ProductId);
            if (product == null)
            {
                return NotFound();
            }
            var cartItemDto = cartItem.FromCartItemToCartItemDto(product);
            return Ok(cartItemDto);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<CartItemDto>> DeleteCartItem(int id)
    {
        var cartItemToRemove = await _iCartRepository.DeleteCartItem(id);
        if (cartItemToRemove == null)
        {
            return NotFound();
        }
        else
        {
            var product = await _iProductRepository.GetItem(cartItemToRemove.ProductId);
            if (product == null)
            {
                return NotFound();
            }
            var cartItemDto = cartItemToRemove.FromCartItemToCartItemDto(product);
            return Ok(cartItemDto);
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<CartItemDto>> AddCartItem([FromBody] CartItemToAddDto cartItemToAddDto)
    {
        if (cartItemToAddDto == null)
        {
            return BadRequest();
        }

        var newCartItem = cartItemToAddDto.FromCartItemToAddDtoToCartItem();
        if (newCartItem == null)
        {
            return NotFound();
        }
        else
        {
            var createdCartItem = await _iCartRepository.AddCartItem(newCartItem);
            if (createdCartItem == null)
            {
                return NotFound();
            }

            var product = await _iProductRepository.GetItem(createdCartItem.ProductId);
            if (product == null)
            {
                return NotFound();
            }

            var cartItemDto = createdCartItem.FromCartItemToCartItemDto(product);
            return Ok(cartItemDto);
            
        }
        
    }
    
    [HttpPut]
    [Route("{id:int}")]
    public async Task<ActionResult<CartItemDto>> UpdateCartItemQuantity([FromRoute] int id,[FromBody] CartItemQuantityUpdateDto cartItemQuantityUpdateDto)
    {
        if (cartItemQuantityUpdateDto == null)
        {
            return BadRequest();
        }

        var cartItem = cartItemQuantityUpdateDto.FromCartItemQuantityUpdateDtoToCartItem();
        var cartItemUpdated = await _iCartRepository.UpdateQuantity(id,cartItem);
        if (cartItemUpdated == null)
        {
            return NotFound();
        }

        var product = await _iProductRepository.GetItem(cartItemUpdated.ProductId);
        var cartItemDto = cartItemUpdated.FromCartItemToCartItemDto(product);
        return Ok(cartItemDto);

    }
    
    
    


}