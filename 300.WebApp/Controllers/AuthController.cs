namespace _300.WebApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;


    [Route("")]
    [ApiController]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("SUCCESS");
        }
    }
}
