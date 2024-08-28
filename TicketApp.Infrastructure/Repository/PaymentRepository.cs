using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class PaymentRepository: BaseRepository<Payment>,IPaymentRepository
    {
        private readonly AppDbContext _context;

        public PaymentRepository(AppDbContext appDbContext): base(appDbContext)
        {
            _context = appDbContext;
        }

    }
}
