using Microsoft.AspNetCore.Mvc;
using VideoGamesAPI.Models;

namespace VideoGamesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevelopersController : ControllerBase
    {
        private static List<Developer> developers = new List<Developer>
        {
            new Developer { Id = 1, Name = "Developer1" },
            new Developer { Id = 2, Name = "Developer2" }
        };

        [HttpGet]
        public IEnumerable<Developer> Get() => developers;

        [HttpGet("{id}")]
        public ActionResult<Developer> Get(int id)
        {
            var developer = developers.FirstOrDefault(d => d.Id == id);
            if (developer == null)
                return NotFound();
            return developer;
        }
    }
}
