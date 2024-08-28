using TicketApp.Core.Entities;

namespace TicketApp.Core.Interfaces
{
    public interface ITripRepository : IBaseRepository<Trip>
    {
        Task<IEnumerable<Trip>> GetTripsByTripGroupId(int id);
        Task<Trip> GetTripByStations(string departureStation, string arrivalStation);

    }
}
