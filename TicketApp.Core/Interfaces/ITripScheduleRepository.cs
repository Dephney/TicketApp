using Microsoft.AspNetCore.JsonPatch;
using TicketApp.Core.Entities;

namespace TicketApp.Core.Interfaces
{
    public interface ITripScheduleRepository : IBaseRepository<TripSchedule>
    {
        Task<IEnumerable<TripScheduleDetail>> GetTripScheduleDetailsByTripId(int id);
        Task<TripScheduleDetail> GetTripScheduleDetailsByTripScheduleId(int id);
        Task UpdateTripSeatsNo(int id, JsonPatchDocument tripSchedule);
    }
}
