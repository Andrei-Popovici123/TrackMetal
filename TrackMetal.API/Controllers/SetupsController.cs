using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrackMetal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetupsController : ControllerBase
    {
        public SetupsController()
        {

        }

        [HttpGet]
        public IActionResult GetAllSetups()
        {
            return Ok();
        }

        [HttpGet, Route("{id}")]
        public IActionResult GetSetupById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateSetup()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSetup()
        {
            return Ok();
        }

        [HttpDelete, Route("{id}")]
        public IActionResult DeleteSetup(int id)
        {
            return Ok();
        }
    }
}
