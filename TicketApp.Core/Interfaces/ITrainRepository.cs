using TicketApp.Core.Entities;

namespace TicketApp.Core.Interfaces
{
    public interface ITrainRepository : IBaseRepository<Train>
    {
        Task<Train> GetTrainByNo(int num);
    }
}
