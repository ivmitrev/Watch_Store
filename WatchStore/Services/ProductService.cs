using System.Net.Http.Json;
using WatchStoreApi.Dtos;

namespace WatchStore.Services;

public class ProductService : IProductService
{
    private readonly HttpClient httpClient;

    public ProductService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<IEnumerable<ProductDto>> GetProducts()
    {
        try
        {
            var response = await this.httpClient.GetAsync($"api/Product");
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<ProductDto>();
                }

                return await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>();
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

    public async Task<ProductDto> GetProduct(int id)
    {
        try
        {
            var response = await this.httpClient.GetAsync($"api/Product/{id}");
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return default(ProductDto);
                }

                return await response.Content.ReadFromJsonAsync<ProductDto>();
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
    
}