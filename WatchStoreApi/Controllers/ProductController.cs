using Microsoft.AspNetCore.Mvc;
using WatchStoreApi.Dtos;
using WatchStoreApi.Extensions;
using WatchStoreApi.Models;
using WatchStoreApi.Repositories;

namespace WatchStoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository; 
    public ProductController(IProductRepository productRepository)
    {
        this._productRepository = productRepository;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
    {
        var products = await _productRepository.GetProducts();
        var categories = await _productRepository.GetCategories();

        if (products == null || categories == null)
        {
            return NotFound();
        }
        else
        {
            var productDtos = products.MapToDto(categories);
            return Ok(productDtos);
        }
        
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProductDto>> GetItem(int id)
    {
        var product = await _productRepository.GetItem(id);
        if (product == null)
        {
            return BadRequest();
        }
        else
        {
            var productCategory = await _productRepository.GetCategory(product.CategoryId);
            var productDto = product.MapToDto(productCategory);
            return Ok(productDto);
        }
        
    }
    [HttpPost]
    public async Task<ActionResult<ProductDto>> CreateProduct([FromBody] ProductCreateDto productCreateDto)
    {
        if (productCreateDto == null)
        {
            return BadRequest("Product data is required");
        }
        var product = productCreateDto.ProductCreateDtoToProduct();
        if (product == null)
        {
           return NotFound();
        }
       
        var createdProduct = await _productRepository.CreateProduct(product);
        var category = await _productRepository.GetCategory(createdProduct.CategoryId);
        return Ok(createdProduct.MapToDto(category));
    }
    
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Product>> DeleteProduct([FromRoute] int id)
    {
        var productRemoved = await _productRepository.DeleteProduct(id);
        if (productRemoved == null)
        {
            return NotFound();
        }
        var category = await _productRepository.GetCategory(productRemoved.CategoryId);
        return Ok(productRemoved.MapToDto(category));
    }
    
    
    [HttpPut]
    [Route("{id:int}")]
    public async Task<ActionResult<Product>> UpdateProduct([FromRoute] int id, [FromBody] ProductUpdateDto productUpdateDto)
    {
        var product = await _productRepository.UpdateProduct(id,productUpdateDto.ToProductFromUpdate());
        if (product == null)
        {
            return NotFound();
        }
        var category = await _productRepository.GetCategory(product.CategoryId);
        return Ok(product.MapToDto(category));


    }
} 