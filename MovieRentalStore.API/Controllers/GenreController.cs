using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MovieRentalStore.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class GenreController : ControllerBase
{
    public GenreController()
    {

    }

    [HttpGet]
    [SwaggerOperation(Summary = "List all genres", Description = "List all genres and its numerical reference.")]
    public IActionResult GetList()
    {
        return Ok();
    }

}
