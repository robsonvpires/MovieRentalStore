using Microsoft.AspNetCore.Mvc;
using MovieRentalStore.API.DTOs;
using Swashbuckle.AspNetCore.Annotations;

namespace MovieRentalStore.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class MovieController : ControllerBase
{
    public MovieController() 
    {
        
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Add new movie", Description = "Add new movie.")]
    public IActionResult Add([FromBody] MovieInputModel movie)
    {
        return Ok(movie);
    }

    [HttpPut]
    [SwaggerOperation(Summary = "Update a movie", Description = "Update existing movie.")]
    public IActionResult Update([FromBody] MovieInputModel movie)
    {
        return Ok(movie);
    }


    [HttpGet]
    [SwaggerOperation(Summary = "Get movies by title", Description = "Return all movies that contains the string in the title.")]
    public IEnumerable<MovieInputModel> GetListByTitle([FromQuery]string title)
    {
        MovieInputModel movie = new() { Title = title };

        List<MovieInputModel> result = new() { movie };

        return result;
    }

    [HttpDelete]
    public IActionResult Delete([FromQuery]int id) 
    {
        return Delete(id);
    }
}
