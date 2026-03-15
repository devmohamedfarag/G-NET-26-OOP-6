namespace AssignmentOOP06.Models
{
    public partial class Cinema
    {
        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened ===");
            Console.WriteLine("Projector ON");
        }

        public void CloseCinema()
        {
            Console.WriteLine("\nProjector OFF");
            Console.WriteLine("=== Cinema Closed ===");
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n====== All Tickets (from Cinema.Reporting) ======");

            foreach (var t in tickets)
            {
                if (t != null)
                    t.Print();
            }
        }
    }
}
