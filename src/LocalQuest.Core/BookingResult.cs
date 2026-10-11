namespace LocalQuest.Core;

public class BookingResult
{
    public bool IsSuccess { get; }
    public Booking? Booking { get; }
    public BookingError? Error { get; }

    private BookingResult(bool isSuccess, Booking? booking, BookingError? error)
    {
        IsSuccess = isSuccess;
        Booking = booking;
        Error = error;
    }

    public static BookingResult Success(Booking booking)
    {
        return new BookingResult(true, booking, null);
    }

    public static BookingResult Failure(BookingError bookingError)
    {
        return new BookingResult(false, null, bookingError);
    }
}
