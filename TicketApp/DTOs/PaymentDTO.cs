namespace TicketApp.TicketAppWebAPI.DTOs
{
    public class PaymentDTO
    {
        public int paymentId { get; set; }
        public int cardNo { get; set; }
        public DateTime expiryDate { get; set; }
        public int cvv { get; set; }
        public float amount { get; set; }
        public DateTime date { get; set; }
    }
}
