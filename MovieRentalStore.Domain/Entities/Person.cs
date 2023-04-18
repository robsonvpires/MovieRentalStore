namespace MovieRentalStore.Domain.Entities;

public class Person : BaseEntity
{
    public Name Name { get; set; }
    public DateTime DateBirth { get; set; }
}