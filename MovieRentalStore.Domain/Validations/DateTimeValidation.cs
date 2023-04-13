using System.ComponentModel.DataAnnotations;

namespace MovieRentalStore.Domain.Validations;

public class MyDateAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        DateTime d = Convert.ToDateTime(value);
        return d <= DateTime.Now; //Dates Greater than or equal to today are valid (true)

    }
}
