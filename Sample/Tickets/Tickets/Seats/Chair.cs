namespace Tickets.Seats;

public class Chair: Seat
{
    public Chair(Guid concertId, string number, decimal price): base(concertId, number, price)
    {
        // Wijziging door iemand anders
    }
}
