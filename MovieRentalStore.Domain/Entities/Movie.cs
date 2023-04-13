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
    }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Title is mandadory.")]
    [StringLength(155, MinimumLength = 3, ErrorMessage = "Title's lenght must be between 3 and 155 characters.")]
    public string Title { get; private set; }

    [Required(ErrorMessage ="Release date is mandatory.")]
    public DateTime Release { get; private set; }

    public IEnumerable<Genre> Genres { get; private set; }

    public TimeSpan Runtime { get; private set; }

    public RuntimeCategory RuntimeCategory
    {
        get { return RuntimeCategory; }
        set
        {
            if (Runtime.TotalMinutes >= 40)
            {
                RuntimeCategory = RuntimeCategory.FeatureFilm;
            }
            else
            {
                RuntimeCategory = RuntimeCategory.ShortFilm;
            }

        }
    }
}
