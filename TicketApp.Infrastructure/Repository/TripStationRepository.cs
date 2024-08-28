using Microsoft.EntityFrameworkCore;
using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class TripStationRepository : BaseRepository<TripStation>,ITripStationRepository
    {
        private readonly AppDbContext _context;

        public TripStationRepository(AppDbContext appDbContext): base(appDbContext)
        {
            _context = appDbContext;
        }



        public async Task<IEnumerable<TripStation>> GetTripStationsByTripId(int id)
        {
            return await _context.TripStations.Where(t => t.tripId == id).ToListAsync();
        }

        public async Task<IEnumerable<StationName>> GetTripStationNamesByTripId(int id)
        {
            var query = from tripStations in _context.TripStations
                        join stations in _context.Stations on tripStations.stationId equals stations.Id
                        where tripStations.tripId == id
                        select new StationName
                        {
                            tripStationId = tripStations.Id,
                            tripId = tripStations.tripId,
                            stationName = stations.stationName

                        };  
            
            var results = await query.ToListAsync();
            return results;
        }


    }
}
