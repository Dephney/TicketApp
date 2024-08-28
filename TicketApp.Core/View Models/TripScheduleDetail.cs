
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.Core.Entities
{
    public class TripScheduleDetail
    {
        [ForeignKey("Trip")]
        public int tripId { get; set; }
        [ForeignKey("TripSchedule")]
        public int tripScheduleId { get; set; }
        [ForeignKey("Train")]
        public int trainId { get; set; }
        [ForeignKey("Schedule")]
        public int scheduleId { get; set; }
        [ForeignKey("TripStatus")]
        public int tripStatusId { get; set; }
        public int trainNo { get; set; }
        [ForeignKey("TripPrice")]
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
