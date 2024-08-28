
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Core.Entities
{
    public class Payment : BaseEntity
    {
        public string? cardNo { get; set; }
        public DateTime expiryDate { get; set; }
        public int cvv {  get; set; }
        public float amount { get; set; }
    
    }
}
