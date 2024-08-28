

using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.Core.Entities
{
    public class StationName
    {
        [ForeignKey("TripStation")]
        public int tripStationId { get; set; }
        [ForeignKey("Trip")]
        public int tripId { get; set; }
        public string? stationName { get; set; }

    }
}
