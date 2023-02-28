using Microsoft.AspNetCore.Mvc;
using OnlineShopApp.Interfaces;
using OnlineShopApp.Models;

namespace OnlineShopApp.Controllers
{
    [ApiController]
    public class ProductsController : Controller
    {
        private IProducts _products;

        public ProductsController(IProducts products)
        {
            _products = products;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetProducts()
        {
            var listproducts = _products.GetProducts();
            return Ok(listproducts);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Create(Product product)
        {
            _products.CreateProducts(product);
            return Created("/"+product.Id,product);
        }

    }
}
