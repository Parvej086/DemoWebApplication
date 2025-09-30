using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace EmployeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMemoryCache _cache;

        public ProductsController(IMemoryCache cache)
        {
            _cache = cache;
        }

        [HttpGet]
        [HttpGet]
        [ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any, NoStore = false)]
        public IActionResult Get()
        {
            var result = new
            {
                Time = DateTime.Now.ToString("HH:mm:ss"),
                Products = new[] { "Apple", "Banana", "Orange" }
            };

            return Ok(result);
        }
    }
}