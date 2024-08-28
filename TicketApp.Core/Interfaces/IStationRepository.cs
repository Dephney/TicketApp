using TicketApp.Core.Entities;

namespace TicketApp.Core.Interfaces
{
    public interface IStationRepository : IBaseRepository<Station>
    {
        List<Station> SearchStation(string search);
    }
}
