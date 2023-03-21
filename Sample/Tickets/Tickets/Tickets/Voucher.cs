using Core.Aggregates;

namespace Tickets.Tickets;

public class Voucher : Aggregate
{
    public Guid SeatId { get; }

    public string Number { get; }

    public Voucher(Guid seatId, string number)
    {
        SeatId = seatId;
        Number = number;
    }
}
