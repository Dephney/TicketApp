namespace TicketApp.TicketAppWebAPI.DTOs
{ 
    public class TripDTO
    {
        public int tripId { get; set; }
        public int trainId { get; set; }
        public int tripPriceId { get; set; }
        public int tripStatusId { get; set; }
        public string? departureStation { get; set; }
        public string? arrivalStation { get; set; }
        public string? departureTime { get; set; }
        public string? arrivalTime { get; set; }
        public int numberOfStops { get; set; }
        public string? tripType { get; set; }
        public char tripGroup { get; set; }
    }
}
