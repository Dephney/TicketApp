using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.TicketAppWebAPI.DTOs
{
    public class AccountDTO
    {
        public int accountId { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? ID { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public DateTime date { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public int accountTypeId { get; set; }
    }
}
