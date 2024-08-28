using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TicketApp.Core.Entities
{
    public class Schedule : BaseEntity
    {
        public string? departureTime { get; set; }
        public string? arrivalTime { get; set; }
        [ForeignKey("TripGroup")]
        public int tripGroupId { get; set; }

    }
}
