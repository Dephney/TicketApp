using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.Core.Entities
{
    public class TripSchedule : BaseEntity
    {
        [ForeignKey("Trip")]
        public int tripId { get; set; }
        [ForeignKey("Schedule")]
        public int scheduleId { get; set; }     
        [ForeignKey("Train")]
        public int trainId { get; set; }
        [ForeignKey("TripStatus")]
        public int tripStatusId { get; set; }
        public int numberOfSeats { get; set; }


    }
}
