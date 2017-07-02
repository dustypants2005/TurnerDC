using Microsoft.AspNetCore.Mvc;
using Turner_demo_server.Entities.Genre;

namespace Turner_demo_server.Controllers
{
    [Produces("application/json")]
    [Route("api/genre")]
    public class GenreController : Controller
    {
        private GenreContext _genreContext;

        public GenreController(GenreContext context)
        {
            _genreContext = context;
        }

        [HttpGet]
        public IActionResult GetGenres()
        {
            var genre = _genreContext.Genre;
            return Ok(genre);
        }
    }
}