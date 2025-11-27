using Microsoft.AspNetCore.Mvc;

namespace TrackMetal.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    public CarsController()
    {

    }

    [HttpGet]
    public IActionResult GetAllCars()
    {
        return Ok();
    }

    [HttpGet, Route("{id}")]
    public IActionResult GetCarById(int id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult CreateCar()
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateCar()
    {
        return Ok();
    }

    [HttpDelete, Route("{id}")]
    public IActionResult DeleteCar(int id)
    {
        return Ok();
    }
}