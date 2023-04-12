using MovieRentalStore.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace MovieRentalStore.Domain.Entities;

public class Movie
{
    public Movie(string title,DateTime release, IEnumerable<Genre> genre, TimeSpan runtime) 
    {
        Title = title;
        Release = release;
        Genres = genre;
        Runtime = runtime;
        RuntimeCategory = SetRuntimeCategory(runtime);
    }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Title is mandadory")]
    [StringLength(155, MinimumLength = 3, ErrorMessage = "Title's lenght must be between 3 and 155 characters.")]
    public string Title { get; private set; }

    public DateTime Release { get; private set; }

    public IEnumerable<Genre> Genres { get; private set; }

    public TimeSpan Runtime { get; private set; }

    public RuntimeCategory RuntimeCategory { get; private set; }

    private RuntimeCategory SetRuntimeCategory(TimeSpan runtime)
    {
        if (runtime.Minutes >= 40)
            return RuntimeCategory.FeatureFilm;

        return RuntimeCategory.ShortFilm;
    }
}
