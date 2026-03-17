using G_NET_33_OOP05;

public class StandardTicket(string movie, string seat, decimal price)
    : TicketBase(movie, seat, price)
{

    public override void Print()
    {
        Console.WriteLine(
            $"[Ticket #{ID}] {MovieName} | Standard | Seat: {Seat} | Price: {Price} | After Tax: {AfterTax()} | Booked: {(IsBooking ? "Yes" : "No")}"
        );
    }

    public override object Clone()
    {
        return new StandardTicket(MovieName, Seat, Price);
    }
}