using Microsoft.AspNetCore.Mvc;
using MovieRentalStore.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace MovieRentalStore.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class GenreController : ControllerBase
{
    private readonly IGenreService _genreService;

    public GenreController(IGenreService genreService)
    {
        _genreService = genreService;
    }

    [HttpGet]
    [SwaggerOperation(Summary = "List all genres", Description = "List all genres and its numerical reference.")]
    public IActionResult GetList()
    {
        var result = _genreService.GetList();
        return Ok(result);
    }

}
