using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketApp.Core.Entities
{
    public class Account : BaseEntity
    {
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? IDNumber { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public DateTime dateRegistered { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }

        [ForeignKey("AccountType")]
        public int accountTypeId { get; set; }



    }
}
