using MovieRentalStore.Domain.Enums;

namespace MovieRentalStore.Domain.Entities;

public class Copy : BaseEntity
{
    public Movie Movie { get; private set; }
    public Media Media { get; private set; }
    public Status Status { get; private set; }
}
