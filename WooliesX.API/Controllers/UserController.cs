using Microsoft.AspNetCore.Mvc;
using WooliesX.API.Helpers;
using WooliesX.Domain;

namespace WooliesX.API.Controllers
{
    [Route("api/answers")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/answers
        // GET api/answers/user
        [HttpGet]
        [HttpGet("user")]
        public IActionResult GetUser()
        {
            var user = new User { Name = "Ramesh Bandarupally", Token = URLConstants.TOKEN_VALUE };
            var result =  new JsonResult(user);
            return result;
        }

    }
}
