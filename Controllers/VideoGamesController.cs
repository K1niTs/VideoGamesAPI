using Microsoft.AspNetCore.Mvc;
using VideoGamesAPI.Models;

namespace VideoGamesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideoGamesController : ControllerBase
    {
        private static List<VideoGame> games = new List<VideoGame>
        {
            new VideoGame { Id = 1, Title = "Game1", Genre = "Genre1" },
            new VideoGame { Id = 2, Title = "Game2", Genre = "Genre2" }
        };

        [HttpGet]
        public IEnumerable<VideoGame> Get() => games;

        [HttpGet("{id}")]
        public ActionResult<VideoGame> Get(int id)
        {
            var game = games.FirstOrDefault(g => g.Id == id);
            if (game == null)
                return NotFound();
            return game;
        }
    }
}
