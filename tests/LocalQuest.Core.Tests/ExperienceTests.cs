namespace LocalQuest.Core.Tests;

public class ExperienceTests
{
    [Fact]

    public void Constructor_StoresTitleAndOrganizer()
    {
        var e = new Experience("Experience1", "Maria");

        Assert.Equal("Maria", e.Organizer);
        Assert.Equal("Experience1", e.Title);

    }

    [Fact]

    public void Constructor_EmptyTitle_Throws()
    {
        Assert.Throws<ArgumentException>(() => new Experience("", "Maria"));
    }

    [Fact]

    public void Constructor_EmptyOrganizer_Throws()
    {
        Assert.Throws<ArgumentException>(() => new Experience("Experience1", ""));
    }

}
