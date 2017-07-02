using Microsoft.AspNetCore.Mvc;
using Turner_demo_server.Entities.StoryLine;

namespace Turner_demo_server.Controllers
{
    [Produces("application/json")]
    [Route("api/storyline")]
    public class StoryLineController : Controller
    {
        private StoryLineContext _storyLineContext;

        public StoryLineController(StoryLineContext context)
        {
            _storyLineContext = context;
        }

        [HttpGet]
        public IActionResult GetStoryLines()
        {
            var sl = _storyLineContext.StoryLine;
            return Ok(sl);
        }
    }
}