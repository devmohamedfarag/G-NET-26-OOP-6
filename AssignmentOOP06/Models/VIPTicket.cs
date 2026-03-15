namespace AssignmentOOP06.Models
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }

        public const decimal ServiceFee = 50m;

        public VIPTicket(string movieName, decimal price, bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override decimal CalculateFinalPrice()
        {
            return (Price + ServiceFee) * 1.14m;
        }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} | Price: {Price} | Final Price: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
