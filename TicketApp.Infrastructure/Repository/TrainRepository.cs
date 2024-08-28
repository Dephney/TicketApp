using Microsoft.EntityFrameworkCore;
using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class TrainRepository: BaseRepository<Train>,ITrainRepository
    {
        private readonly AppDbContext _context;

        public TrainRepository(AppDbContext appDbContext):base(appDbContext)
        {
            _context = appDbContext;
        }
        public async Task<Train> GetTrainByNo(int num)
        {
            return await _context.Trains.SingleOrDefaultAsync(t => t.trainNo == num);
        }

    }
}
