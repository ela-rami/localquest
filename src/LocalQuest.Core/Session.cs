namespace LocalQuest.Core;

public class Session
{
    public Guid Id { get; }
    public Experience Experience { get; }
    public DateTimeOffset StartsAt { get; }
    public int Capacity { get; }
    public decimal Price { get; }
    public int SeatsLeft { get; private set; }

    public Session(Experience experience, DateTimeOffset startsAt, int capacity, decimal price)
    {

        if (experience == null)
        {
            throw new ArgumentNullException(nameof(experience));
        }

        if (capacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(capacity));
        }

        if (price < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price));
        }

        Id = Guid.NewGuid();
        Experience = experience;
        StartsAt = startsAt;
        Capacity = capacity;
        Price = price;
        SeatsLeft = capacity;
    }
}
