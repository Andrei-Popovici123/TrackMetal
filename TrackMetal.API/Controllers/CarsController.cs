using Microsoft.AspNetCore.Mvc;

namespace TrackMetal.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    public CarsController()
    {
        
    }

    [HttpGet, Route("api/cars")]
    public IActionResult GetAllCars()
    {
        return Ok();
    }
}