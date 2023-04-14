namespace MovieRentalStore.API.DTOs;

public class MovieInputModel
{
    public string Title { get; set; }
    public DateTime release { get; set; }
    //TODO: Use Enum from Domain?
    public IEnumerable<string> genre { get; set; }
    public TimeSpan Runtime { get; set; }

}
