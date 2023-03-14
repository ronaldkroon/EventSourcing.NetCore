namespace Tickets.Reservations.NumberGeneration;

internal class ReservationNumberGenerator1: IReservationNumberGenerator
{
    public string Next() => Guid.NewGuid().ToString();
}
