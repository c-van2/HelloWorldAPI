using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            var message = $"Hello, World!";
            return Ok(new { message });
        }
    }
}
