using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class TripGroupRepository:BaseRepository<TripGroup>,ITripGroupRepository
    {
        private readonly AppDbContext _context;

        public TripGroupRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }
    }
}
