namespace G_NET_33_OOP05;

public class VipTicket(string movie, string seat, decimal price, bool loung, decimal fee) : TicketBase(movie, seat, price)
{
    public bool Lounge { get; set; } = loung;
    public decimal Fee { get; set; } = fee;

    public override decimal AfterTax()
    {
        return (Price+50)*1.14m;
    }
    private decimal TotalPrice() => AfterTax() + (Lounge ? Fee : 0);
    public override void Print()
    {
        Console.WriteLine(
         $"[Ticket #{ID}] {MovieName} | Vip | Seat: {Seat} | Price: {Price} | After Tax: {AfterTax()} | Booked: {(IsBooking ? "Yes" : "No")} Loung :{Lounge} | Fee : {Fee} FinalPrice: {TotalPrice()}"
     );
    }

    public override object Clone()
    {
        return new VipTicket(MovieName, Seat, Price, Lounge, Fee);
    }
}
