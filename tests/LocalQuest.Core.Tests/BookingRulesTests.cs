namespace LocalQuest.Core.Tests;

public class BookingRulesTests
{
    [Fact]
    public void IsValidPartySize_AcceptsOnly1To8()
    {
        Assert.True(BookingRules.IsValidPartySize(1));
        Assert.False(BookingRules.IsValidPartySize(0));
        Assert.True(BookingRules.IsValidPartySize(8));
        Assert.False(BookingRules.IsValidPartySize(9));
    }
}
