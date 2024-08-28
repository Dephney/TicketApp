using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.Core.Entities
{
    public class Trip : BaseEntity
    {
        [ForeignKey("TripPrice")]
        public int tripPriceId { get; set; }
        public string? departureStation { get; set; }
        public string? arrivalStation { get; set; }     
        public int numberOfStops { get; set; }
        [ForeignKey("TripGroup")]
        public int tripGroupId { get; set; }

    }
}
