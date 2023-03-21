using Core.Aggregates;

namespace Tickets.Concerts;

public class Festival : Aggregate
{
    public string Name { get; }

    public DateTime Date { get; }

    public Festival(string name, DateTime date)
    {
        Name = name;
        Date = date;
    }
}
