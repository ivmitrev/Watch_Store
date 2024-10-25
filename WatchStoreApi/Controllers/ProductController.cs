using Microsoft.AspNetCore.Mvc;
using WatchStoreApi.Repositories;

namespace WatchStoreApi.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    public ProductController(IProductRepository productRepository)
    {
        this._productRepository = productRepository;
    }
    // GET
    public IActionResult Index()
    {
        return View();
    }
} 