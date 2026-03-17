using System.Diagnostics.Metrics;

namespace G_NET_33_OOP05;

public class TicketBase(string movie, string seat, decimal price) : ICloneable, IPrintable, IBoolable
{
    private static int Counter = 1;
    public int ID { get; } = Counter++;
    public string MovieName { get; set; } = movie;

    public string Seat { get; set; } = seat;
    public decimal Price { get; set; } = price;

    public bool IsBooking { get; set; }




    public bool Book()
    {
        if (IsBooking) return false;
        IsBooking = true;
        return true;
    }

    public bool Cancel()
    {
        if (!IsBooking) return false;
        IsBooking = false;
        return true;
    }

    public virtual object Clone()
    {

        return MemberwiseClone();
    }

    public virtual void Print() { }

    public virtual decimal AfterTax() => Price * 1.14m;
}
