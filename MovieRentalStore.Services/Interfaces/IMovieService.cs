using MovieRentalStore.API.DTOs;

namespace MovieRentalStore.Services.Interfaces;

public interface IMovieService
{
    public string Add(MovieInputModel movie);
    public bool Remove();
    public void Update(MovieInputModel movie);
    public IEnumerable<MovieInputModel> GetListByTitle(string title);
}