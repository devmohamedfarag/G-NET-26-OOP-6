namespace AssignmentOOP06.Models
{
    public class IMAXTicket : Ticket
    {
        public bool IS3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3d) : base(movieName, price)
        {
            IS3D = is3d;

            if (IS3D)
            {
                Price += 30m;
            }
        }

        public override decimal CalculateFinalPrice() => Price * 1.14m;

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(IS3D ? "Yes" : "No")} | Price: {Price} | Final Price: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

    }
}
