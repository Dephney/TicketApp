using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TicketApp.Core.Entities
{
    public class TripStatus : BaseEntity
    {
        public string? statusName { get; set; }
    }
}
