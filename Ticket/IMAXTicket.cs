namespace G_NET_33_OOP05;

public class IMAXTicket (string movie, string seat, decimal price,bool is3D) : TicketBase(movie, seat, price)
{
    public bool IS3D {get;set;}=is3D;

    
       public override decimal AfterTax()
    {
        return (Price+150)*1.14m;
    }
    private decimal TotalPrice()=> AfterTax() + (IS3D? 50:0);
    public override void Print()
    {
   Console.WriteLine(
            $"[Ticket #{ID}] {MovieName} | IMAX | Seat: {Seat} | Price: {Price} | After Tax: {AfterTax()} | Booked: {(IsBooking ? "Yes" : "No")} IS3D :{(IS3D?"Yes":"No")} | FinalPrice :{TotalPrice()}"
        );    }
    public override object Clone()
    {
        return new IMAXTicket(MovieName,Seat,Price,IS3D);
    }
}
