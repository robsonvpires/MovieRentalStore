namespace MovieRentalStore.API.DTO;

public class MovieDTO
{
    public string Title { get; set; }
    public DateTime release { get; set; }
    //TODO: Use Enum from Domain?
    public IEnumerable<int> genre { get; set; }
    public TimeSpan Runtime { get; set; }

}
