﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Core.Entities;

namespace TicketApp.Core.Interfaces
{
    public interface IBookingRepository : IBaseRepository<Booking>
    {
        Task<IEnumerable<Booking>> GetBookingsByTripScheduleId(int id);

    }
}