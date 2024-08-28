using TicketApp.Core.Entities;

namespace TicketApp.Core.Interfaces
{
    public interface ITripStationRepository : IBaseRepository<TripStation>
    {
        Task<IEnumerable<TripStation>> GetTripStationsByTripId(int id);
        Task<IEnumerable<StationName>> GetTripStationNamesByTripId(int id);

    }
}
