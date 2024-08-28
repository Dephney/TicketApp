using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;

namespace TicketApp.Infrastructure.Repository
{
    public class AccountTypeRepository: BaseRepository<AccountType>, IAccountTypeRepository
    {
        private readonly AppDbContext _context;

        public AccountTypeRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }
    }
}
