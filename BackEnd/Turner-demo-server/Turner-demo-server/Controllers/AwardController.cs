using Microsoft.AspNetCore.Mvc;
using Turner_demo_server.Entities.Award;

namespace Turner_demo_server.Controllers
{
    [Produces("application/json")]
    [Route("api/award")]
    public class AwardController : Controller
    {
        private AwardContext _awardContext;

        public AwardController(AwardContext context)
        {
            _awardContext = context;
        }
        
        [HttpGet]
        public IActionResult GetAwards()
        {
            var awards = _awardContext.Award;
            return Ok(awards);
        }
    }
}