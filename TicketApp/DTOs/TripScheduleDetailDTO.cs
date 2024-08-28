namespace TicketApp.TicketAppWebAPI.DTOs
{
    public class TripScheduleDetailDTO
    {
        public int tripId { get; set; }
        public int tripScheduleId { get; set; }
        public int trainId { get; set; }
        public int scheduleId { get; set; }
        public int tripStatusId { get; set; }
        public int trainNo { get; set; }
        public int tripPriceId { get; set; }
        public string? statusName { get; set; }
        public string? departureStation { get; set; }
        public string? arrivalStation { get; set; }
        public string? departureTime { get; set; }
        public string? arrivalTime { get; set; }
        public int numberOfStops { get; set; }
        public int numberOfSeats { get; set; }

    }
}
