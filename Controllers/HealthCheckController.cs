using Microsoft.AspNetCore.Mvc;

namespace VideoGamesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Service is up and running");
    }
}
