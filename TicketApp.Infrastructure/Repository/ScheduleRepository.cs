using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class ScheduleRepository:BaseRepository<Schedule>,IScheduleRepository
    {
        private readonly AppDbContext _context;

        public ScheduleRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }
    }
}
