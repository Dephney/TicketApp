namespace TicketApp.TicketAppWebAPI.DTOs
{
    public class StationNameDTO
    {
        public int tripStationId { get; set; }
        public int tripId { get; set; }
        public string? stationName { get; set; }
    }
}
