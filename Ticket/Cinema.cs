using G_NET_33_OOP05;

public class Cinema
{
    private List<IPrintable> tickets = new();
    public IReadOnlyList<IPrintable> Tickets => tickets.AsReadOnly();

    public void Open() => Console.WriteLine("==== Cinema Opened ====\n");
    public void Close() => Console.WriteLine("\n==== Cinema Closed ====");

    public void AddTicket(IPrintable t)
    {
        tickets.Add(t);
    }

    public void PrintAll()
    {
        foreach (var t in Tickets)
            t.Print();
    }

    //  Cancel by ID
  public bool CancelTicket(int id)
{
    for (int i = 0; i < tickets.Count; i++)
    {
        if (tickets[i] is TicketBase tb && tb.ID == id)
        {
            tb.Cancel();
            tickets.RemoveAt(i);
            return true;
        }
    }

    return false;
}

    //  Clone by ID
  public bool CloneTicket(int id)
{
    foreach (var t in tickets)
    {
        if (t is TicketBase tb && tb.ID == id)
        {
            var cloned = (TicketBase)tb.Clone();

            cloned.Cancel(); // 👈 مهم جدًا يخليه Not Booked

            tickets.Add(cloned);
            return true;
        }
    }
    return false;
}

    //  Total Revenue (Booked only)
    public decimal GetRevenue()
    {
        decimal total = 0;

        foreach (var t in tickets)
        {
            if (t is TicketBase tb && tb.IsBooking)
            {
                total += tb.AfterTax();
            }
        }

        return total;
    }
}