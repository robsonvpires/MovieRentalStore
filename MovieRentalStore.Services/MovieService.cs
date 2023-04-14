using MovieRentalStore.API.DTO;
using MovieRentalStore.Services.Interfaces;

namespace MovieRentalStore.Services;

public class MovieService : IMovieService
{
    public string Add(MovieDTO movie)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<MovieDTO> GetListByTitle(string title)
    {
        throw new NotImplementedException();
    }

    public bool Delete(string id)
    {
        throw new NotImplementedException();
    }

    public void Update(MovieDTO movie)
    {
        throw new NotImplementedException();
    }
}