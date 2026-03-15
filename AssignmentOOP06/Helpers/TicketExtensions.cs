using AssignmentOOP06.Models;

namespace AssignmentOOP06.Helpers
{
    public static class TicketExtensions
    {
        public static string GenerateReceipt(this Ticket t)
        {
            return $"""
            ========== RECEIPT ==========
              Movie    : {t.MovieName}
              Type     : {t.GetType().Name}
              Price    : {t.Price}
              Final    : {t.CalculateFinalPrice():F2}
              Status   : {(t.IsBooked ? "Booked" : "Not Booked")}
            =============================
            """;
        }

        public static decimal TotalRevenue(this Ticket[] tickets)
        {
            decimal total = 0;

            foreach (var t in tickets)
                total += t.CalculateFinalPrice();

            return total;
        }
    }
}

