using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.Core.Entities
{
    public class TripStation : BaseEntity
    {
        [ForeignKey("Trip")]
        public int tripId { get; set; }
        [ForeignKey("Station")]
        public int stationId { get; set; }

    }
}
