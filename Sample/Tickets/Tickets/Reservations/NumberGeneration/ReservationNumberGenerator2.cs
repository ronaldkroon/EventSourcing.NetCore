namespace Tickets.Reservations.NumberGeneration;

internal class ReservationNumberGenerator2: IReservationNumberGenerator
{
    public string Next() => Guid.NewGuid().ToString();
}
