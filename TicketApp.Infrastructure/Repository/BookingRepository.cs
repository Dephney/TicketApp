using Microsoft.EntityFrameworkCore;
using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class BookingRepository: BaseRepository<Booking>, IBookingRepository
    {
        private readonly AppDbContext _context;

        public BookingRepository(AppDbContext appDbContext): base(appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<IEnumerable<Booking>> GetBookingsByTripScheduleId(int id)
        {
            return await _context.Bookings.Where(b => b.tripScheduleId == id).ToListAsync();
        }

    }
}
