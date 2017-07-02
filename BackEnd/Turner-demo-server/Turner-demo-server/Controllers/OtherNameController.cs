using Microsoft.AspNetCore.Mvc;
using Turner_demo_server.Entities.OtherName;

namespace Turner_demo_server.Controllers
{
    [Produces("application/json")]
    [Route("api/othername")]
    public class OtherNameController : Controller
    {
        private OtherNameContext _otherNameContext;

        public OtherNameController(OtherNameContext context)
        {
            _otherNameContext = context;
        }

        [HttpGet]
        public IActionResult GetOtherNames()
        {
            var otherName = _otherNameContext.OtherName;
            return Ok(otherName);
        }
    }
}