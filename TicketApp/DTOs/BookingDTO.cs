
namespace TicketApp.TicketAppWebAPI.DTOs
{
    public class BookingDTO
    {
        public int bookingId { get; set; }
        public string? bookingRef { get; set; }
        public int numOfTickets { get; set; }
        public int accountId { get; set; }
        public int tripScheduleId { get; set; }
        public int paymentId { get; set; }
    }
}
