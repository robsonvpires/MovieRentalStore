using MovieRentalStore.Domain.Enums;

namespace MovieRentalStore.Services.Interfaces;

public interface IGenreService
{
    public IEnumerable<string> GetList();
}