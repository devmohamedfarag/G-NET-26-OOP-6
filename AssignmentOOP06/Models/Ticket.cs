namespace AssignmentOOP06.Models
{
    public abstract class Ticket
    {
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; set; }

        private static int _ticketCounter = 0;

        protected Ticket(string movieName, decimal price)
        {
            _ticketCounter++;
            TicketId = _ticketCounter;
            MovieName = movieName;
            Price = price;
        }

        public bool Book()
        {
            if (IsBooked)
            {
                Console.WriteLine($"Ticket {TicketId} for '{MovieName}' is already booked.");
                return false;
            }
            IsBooked = true;
            return true;
        }

        public virtual void Print() 
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price}");
        }

        public abstract decimal CalculateFinalPrice();
    }
    
}
