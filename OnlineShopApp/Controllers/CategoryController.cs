using Microsoft.AspNetCore.Mvc;
using OnlineShopApp.Interfaces;
using OnlineShopApp.Models;
using System.Reflection.Metadata.Ecma335;

namespace OnlineShopApp.Controllers
{
    [ApiController]
    public class CategoryController : Controller
    {
        private ICategory _Icategory;

        public CategoryController(ICategory category)
        {
            _Icategory = category;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCategories()
        {
            var categoryLists = _Icategory.GetCategories();
            return Ok(categoryLists);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult CreateCategory(Category category)
        {
            _Icategory.CreateCategory(category);
            return Created("/" + category.Id, category);
        }
    }
}
