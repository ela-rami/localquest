namespace LocalQuest.Core.Tests;

public class SessionTests
{
    [Theory]
    [InlineData(10)]
    [InlineData(10.05)]
    [InlineData(0)]
    public void Constructor_ValidValues_AreStored(decimal price)
    {
        var start = new DateTimeOffset(2026, 10, 18, 10, 0, 0, TimeSpan.FromHours(2));

        var experience = new Experience("A", "Maria");

        var session = new Session(experience, start, 5, price);

        Assert.Equal(experience, session.Experience);
        Assert.Equal(start, session.StartsAt);
        Assert.Equal(5, session.Capacity);
        Assert.Equal(price, session.Price);
        Assert.Equal(session.Capacity, session.SeatsLeft);
    }

    [Fact]
    public void Constructor_NullExperience_Throws()
    {

        var start = new DateTimeOffset(2026, 10, 18, 10, 0, 0, TimeSpan.FromHours(2));

        Assert.Throws<ArgumentNullException>(() => new Session(null!, start, 5, 10));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Constructor_ZeroOrNegativeCapacity_Throws(int capacity)
    {
        var start = new DateTimeOffset(2026, 10, 18, 10, 0, 0, TimeSpan.FromHours(2));
        var experience = new Experience("A", "Maria");

        Assert.Throws<ArgumentOutOfRangeException>(() => new Session(experience, start, capacity, 10));
    }

    [Theory]
    [InlineData(-10)]
    [InlineData(-10.05)]
    [InlineData(-0.01)]
    public void Constructor_NegativePrice_Throws(decimal price)
    {
        var start = new DateTimeOffset(2026, 10, 18, 10, 0, 0, TimeSpan.FromHours(2));
        var experience = new Experience("A", "Maria");

        Assert.Throws<ArgumentOutOfRangeException>(() => new Session(experience, start, 5, price));
    }
}
