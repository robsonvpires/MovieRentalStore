using Microsoft.AspNetCore.Mvc;
using MovieRentalStore.API.DTO;
using MovieRentalStore.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace MovieRentalStore.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MovieController(IMovieService movieService) 
    {
        _movieService = movieService;
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Add new movie", Description = "Add new movie.")]
    public IActionResult Add([FromBody] MovieDTO movie)
    {
        string result = _movieService.Add(movie);
        return Ok(result);
    }

    [HttpPut]
    [SwaggerOperation(Summary = "Update a movie", Description = "Update existing movie.")]
    public IActionResult Update([FromBody] MovieDTO movie)
    {
        _movieService.Update(movie);
        return Ok();
    }


    [HttpGet]
    [SwaggerOperation(Summary = "Get movies by title", Description = "Return all movies that contains the string in the title.")]
    public IEnumerable<MovieDTO> GetListByTitle([FromQuery]string title)
    {
        MovieDTO movie = new() { Title = title };

        List<MovieDTO> result = new() { movie };

        return result;
    }

    [HttpDelete]
    public IActionResult Delete([FromQuery]string id) 
    {
        var result = _movieService.Delete(id);
        return Ok(result);
    }
}
