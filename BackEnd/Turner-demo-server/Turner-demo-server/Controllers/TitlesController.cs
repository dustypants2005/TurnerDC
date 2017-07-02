using Microsoft.AspNetCore.Mvc;
using Turner_demo_server.Entities.Title;

namespace Turner_demo_server.Controllers
{
    [Produces("application/json")]
    [Route("api/titles")]
    public class TitlesController : Controller
    {
        private TitleContext _titleContext;

        public TitlesController(TitleContext titleContext)
        {
            _titleContext = titleContext;
        }

        [HttpGet]
        public IActionResult GetAllTitles()
        {
            var titles = _titleContext.Title;
            return Ok(titles);
        }
    }
}