namespace LocalQuest.Core;

public static class BookingRules
{
    public static bool IsValidPartySize(int people)
    {
        if (people >= 1 && people <= 8)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
