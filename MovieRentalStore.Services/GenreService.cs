using MovieRentalStore.Domain.Enums;
using MovieRentalStore.Domain.Helpers;
using MovieRentalStore.Services.Interfaces;

namespace MovieRentalStore.Services;

public class GenreService : IGenreService
{
    public GenreService() { }

    public IEnumerable<string> GetList()
    {
        IEnumerable<string> result = EnumHelper.GetValuesAndNamesList<Genre>();
        return result;
    }
}
