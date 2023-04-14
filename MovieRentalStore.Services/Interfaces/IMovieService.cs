using MovieRentalStore.API.DTO;

namespace MovieRentalStore.Services.Interfaces;

public interface IMovieService
{
    public string Add(MovieDTO movie);
    public bool Delete(string id);
    public void Update(MovieDTO movie);
    public IEnumerable<MovieDTO> GetListByTitle(string title);
}