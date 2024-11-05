using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using WatchStoreApi.Dtos;

namespace WatchStore.Services;

public class CartItemService : ICartItemService
{
    private readonly HttpClient _httpClient;

    public CartItemService(HttpClient httpClient)
    {
        this._httpClient = httpClient;
    }

    public async Task<IEnumerable<CartItemDto>> GetCartItems()
    {
        try
        {
            var response = await this._httpClient.GetAsync("api/CartItem");
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<CartItemDto>();
                }

                return await response.Content.ReadFromJsonAsync<IEnumerable<CartItemDto>>();
            }
            else
            {
                throw new Exception(($"{await response.Content.ReadAsStringAsync()}"));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<CartItemDto> GetCartItem(int id)
    {
        try
        {
            var response = await this._httpClient.GetAsync($"api/CartItem/{id}");
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return default(CartItemDto);
                }

                return await response.Content.ReadFromJsonAsync<CartItemDto>();
            }
            else
            {
                throw new Exception($"{await response.Content.ReadAsStringAsync()}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public async Task<CartItemDto> AddCartItem(CartItemToAddDto cartItemToAddDto)
    {
        try
        {
            var response = await this._httpClient.PostAsJsonAsync<CartItemToAddDto>("api/CartItem", cartItemToAddDto);
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return default(CartItemDto);
                }

                return await response.Content.ReadFromJsonAsync<CartItemDto>();
            }
            else
            {
                throw new Exception($"{await response.Content.ReadAsStringAsync()}");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

    }

    public async Task<CartItemDto> DeleteCartItem(int id)
    {
        try
        {
            var response = await this._httpClient.DeleteAsync($"api/CartItem/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CartItemDto>();
            }

            return default(CartItemDto);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
    
    public async Task<CartItemDto> UpdateCartItemQuantity(int id, CartItemQuantityUpdateDto cartItemQuantityUpdateDto)
    {
        try
        {
            var jsonContent = new StringContent(JsonSerializer.Serialize(cartItemQuantityUpdateDto), Encoding.UTF8,
                "application/json-patch+json");
            var response = await this._httpClient.PatchAsync($"api/CartItem/{id}", jsonContent);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CartItemDto>();
            }
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}