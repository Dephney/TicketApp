using Microsoft.EntityFrameworkCore;
using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class TripRepository : BaseRepository<Trip>,ITripRepository
    {
        private readonly AppDbContext _context;

        public TripRepository(AppDbContext appDbContext): base(appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<IEnumerable<Trip>> GetTripsByTripGroupId(int id)
        {
            return await _context.Trips.Where(t => t.tripGroupId == id).ToListAsync();
        }

        public async Task<Trip> GetTripByStations(string departureStation, string arrivalStation)
        {
            return await _context.Trips.Where(t => t.departureStation == departureStation && t.arrivalStation == arrivalStation).SingleOrDefaultAsync();
        }
        
    }
}
