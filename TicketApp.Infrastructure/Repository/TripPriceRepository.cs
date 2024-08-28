using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class TripPriceRepository: BaseRepository<TripPrice>,ITripPriceRepository
    {
        private readonly AppDbContext _context;

        public TripPriceRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }

    }
}
