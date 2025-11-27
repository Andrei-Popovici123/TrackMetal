using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrackMetal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CornersController : ControllerBase
    {
        public CornersController()
        {

        }

        [HttpGet]
        public IActionResult GetAllCorners()
        {
            return Ok();
        }

        [HttpGet, Route("{id}")]
        public IActionResult GetCornerById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateCorner()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCorner()
        {
            return Ok();
        }

        [HttpDelete, Route("{id}")]
        public IActionResult DeleteCorner(int id)
        {
            return Ok();
        }
    }
}
