
namespace TicketApp.TicketAppWebAPI.DTOs
{
    public class TripScheduleDTO
    {
        public int tripScheduleId { get; set; }
        public int tripId { get; set; }
        public int scheduleId { get; set; }
        public int trainId { get; set; }
        public int tripStatusId { get; set; }
        public int numberOfSeats { get; set; }
    }
}
