using WatchStoreApi.Dtos;
using WatchStoreApi.Models;

namespace WatchStoreApi.Extensions;

public static class DtoMappers
{
    public static IEnumerable<ProductDto> MapToDto(this IEnumerable<Product> products, IEnumerable<ProductCategory> categories)
    {
        return (from product in products
            join category in categories
                on product.CategoryId equals category.Id
            select new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image,
                Quantity = product.Quantity,
                CategoryId = product.CategoryId,
                CategoryName = category.Name
            }).ToList();
    }

    public static ProductDto MapToDto(this Product product, ProductCategory category)
    {
        return new ProductDto()
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Image = product.Image,
            Quantity = product.Quantity,
            CategoryId = product.CategoryId,
            CategoryName = category.Name
        };
    }

    public static Product ProductCreateDtoToProduct(this ProductCreateDto product)
    {
        return new Product()
        {
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Image = product.Image,
            Quantity = product.Quantity,
            CategoryId = product.CategoryId
        };
    }

    public static Product ToProductFromUpdate(this ProductUpdateDto product)
    {
        return new Product()
        {
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Image = product.Image,
            Quantity = product.Quantity,
            CategoryId = product.CategoryId
        };
    }
    
    // ---------------------

    public static CartItemDto FromCartItemToCartItemDto(this CartItem cartItem, Product product)
    {

        return new CartItemDto()
        {
            Id = cartItem.Id,
            ProductId = cartItem.ProductId,
            Quantity = cartItem.Quantity,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            Image = product.Image,
            TotalPrice = cartItem.Quantity * product.Price
        };
    }
    
    public static IEnumerable<CartItemDto> FromCartItemToCartItemDtos(this IEnumerable<CartItem> cartItems, IEnumerable<Product> products)
    {
        return (from cartItem in cartItems
            join product in products
                on cartItem.ProductId equals product.Id
            select new CartItemDto()
            {
                Id = cartItem.Id,
                ProductId = cartItem.ProductId,
                Quantity = cartItem.Quantity,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image,
                TotalPrice = cartItem.Quantity * product.Price
            }).ToList();
    }
    
    
    public static CartItem FromCartItemToAddDtoToCartItem(this CartItemToAddDto cartItemToAddDto)
    {
        return new CartItem()
        {
            ProductId = cartItemToAddDto.ProductId,
            Quantity = cartItemToAddDto.Quantity,
        };
    }
    
    public static CartItem FromCartItemQuantityUpdateDtoToCartItem(this CartItemQuantityUpdateDto cartItemQuantityUpdateDto)
    {
        return new CartItem()
        {
            ProductId = cartItemQuantityUpdateDto.ProductId,
            Quantity = cartItemQuantityUpdateDto.Quantity,
        };
    }
    


}

