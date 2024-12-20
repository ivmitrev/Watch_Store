﻿
using WatchStoreApi.Dtos;

namespace WatchStore.Services;

public interface IProductService
{ 
    Task<IEnumerable<ProductDto>> GetProducts();
    Task<ProductDto> GetProduct(int id);

}