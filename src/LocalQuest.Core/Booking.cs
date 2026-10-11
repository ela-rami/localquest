namespace LocalQuest.Core;

public class Booking
{
    public Guid Id { get; }
    public Session Session { get; }
    public string CustomerName { get; }
    public int People { get; }
    public decimal UnitPrice { get; }
    public decimal Total { get; }

    internal Booking(Session session, string customerName, int people)
    {
        Id = Guid.NewGuid();
        Session = session;
        CustomerName = customerName;
        People = people;
        UnitPrice = Session.Price;
        Total = UnitPrice * People;
    }


}
