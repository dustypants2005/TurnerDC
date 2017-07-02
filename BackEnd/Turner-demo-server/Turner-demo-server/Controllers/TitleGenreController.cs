using Microsoft.AspNetCore.Mvc;
using Turner_demo_server.Entities.TitleGenre;

namespace Turner_demo_server.Controllers
{
    [Produces("application/json")]
    [Route("api/titlegenre")]
    public class TitleGenreController : Controller
    {
        private TitleGenreContext _titleGenreContext;

        public TitleGenreController(TitleGenreContext context)
        {
            _titleGenreContext = context;
        }

        [HttpGet]
        public IActionResult GetTitleGenres()
        {
            var tg = _titleGenreContext.TitleGenre;
            return Ok(tg);
        }
    }
}