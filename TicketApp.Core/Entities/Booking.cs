  using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.Core.Entities
{
    public class Booking : BaseEntity
    {
        public string? bookingRef { get; set; }
        [ForeignKey("Account")] //Foreign Key property
        public int accountId { get; set; }
        [ForeignKey("TripSchedule")]
        public int tripScheduleId { get; set; }
        [ForeignKey("Payment")]
        public int paymentId { get; set; }
        public int numOfTickets { get; set; }


        /*public Account Account { get; set; } //navigation property */
    }
}
