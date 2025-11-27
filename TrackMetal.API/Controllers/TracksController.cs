using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrackMetal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TracksController : ControllerBase
    {
        public TracksController()
        {

        }

        [HttpGet]
        public IActionResult GetAllTracks()
        {
            return Ok();
        }

        [HttpGet, Route("{id}")]
        public IActionResult GetTrackById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateTrack()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTrack()
        {
            return Ok();
        }

        [HttpDelete, Route("{id}")]
        public IActionResult DeleteTrack(int id)
        {
            return Ok();
        }
    }
}
