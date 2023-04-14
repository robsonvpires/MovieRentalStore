namespace MovieRentalStore.Domain.Entities;

public class Person : BaseEntity
{
    public Name Name { get; set; }
    public DateTime DateBirth { get; set; }
}

public class Name
{
    public string FristName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get;}
}