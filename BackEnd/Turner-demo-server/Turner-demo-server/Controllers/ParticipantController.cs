using Microsoft.AspNetCore.Mvc;
using Turner_demo_server.Entities.Participant;

namespace Turner_demo_server.Controllers
{
    [Produces("application/json")]
    [Route("api/participant")]
    public class ParticipantController : Controller
    {
        private ParticipantContext _participantContext;

        public ParticipantController(ParticipantContext context)
        {
            _participantContext = context;
        }

        [HttpGet]
        public IActionResult GetParticipants()
        {
            var p = _participantContext.Participant;
            return Ok(p);
        }
    }
}