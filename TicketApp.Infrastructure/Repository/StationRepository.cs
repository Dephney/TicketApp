using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class StationRepository : BaseRepository<Station>,IStationRepository
    {
        private readonly AppDbContext _context;
        public StationRepository(AppDbContext appDbContext): base(appDbContext)
        {
            _context = appDbContext;
        }
        public List<Station> SearchStation(string search)
        {
            return  _context.Stations.Where(s => s.stationName.StartsWith(search)).ToList();
   
        }

    }
}
