namespace LocalQuest.Core;

public static class BookingRules
{
    public static bool IsValidPartySize(int n)
    {
        if (n < 1)
        {

            return false;

        }
        else if (n > 8)
        {

            return false;
        }
        else
        {

            return true;
        }

    }
}
