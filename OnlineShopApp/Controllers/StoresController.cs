using Microsoft.AspNetCore.Mvc;
using OnlineShopApp.Interfaces;
using OnlineShopApp.Models;

namespace OnlineShopApp.Controllers
{
    [ApiController]
    public class StoresController : Controller
    {
        private IStores _stores;
        public StoresController(IStores store)
        {
            _stores = store;
        }


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStores()
        {
            var getstores = _stores.GetStores();
            return Ok(getstores);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult CreateStores(Store store)
        {
            _stores.CreateStores(store);
            return Created("/" + store.Id,store);
        }
    }
}
