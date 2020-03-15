using Microsoft.AspNetCore.Mvc;
using WooliesX.API.Services;

namespace WooliesX.API.Controllers
{
    [Route("api/answers/[controller]")]
    [ApiController]
    public class SortController : ControllerBase
    {
        readonly IProductService _productService;
        public SortController(IProductService productService)
        {
            _productService = productService;
        }
        // GET api/answers/sort?sortoption=low
        [HttpGet]
        public IActionResult SortProducts([FromQuery] string sortOption)
        {
            try
            {
                var result = _productService.GetProducts(sortOption);
                return new JsonResult(result);
            }
            catch
            {
                return new BadRequestResult();
            }
        }
    }
}
