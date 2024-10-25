﻿using System.Net.Http.Json;
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
        var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
        return products;
    }
}