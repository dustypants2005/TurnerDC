using Microsoft.AspNetCore.Mvc;
using Turner_demo_server.Entities.TitleParticipant;

namespace Turner_demo_server.Controllers
{
    [Produces("application/json")]
    [Route("api/titleparticipant")]
    public class TitleParticipantController : Controller
    {
        private TitleParticipantContext _titleParticipantContext;

        public TitleParticipantController(TitleParticipantContext context)
        {
            _titleParticipantContext = context;
        }

        [HttpGet]
        public IActionResult GetTitleParticipants()
        {
            var tp = _titleParticipantContext.TitleParticipant;
            return Ok(tp);
        }
    }
}