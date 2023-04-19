namespace MovieRentalStore.Domain.Entities;

public class Rent : BaseEntity
{
    public List<Copy> Copies { get; private set; }
    public Client Client { get; private set; }
    public DateTime Withdrawal { get; private set; }
    public DateTime Delivery { get; private set; }

    public double DaysUntilDelivery()
        => (this.Delivery - DateTime.Today).TotalDays;
    
    public void ExtendDelivery(int days)
        => this.Delivery.AddDays(days);

}
