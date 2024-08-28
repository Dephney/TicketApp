using Microsoft.EntityFrameworkCore;
using TicketApp.Core.Entities;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;


namespace TicketApp.Infrastructure.Repository
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        private readonly AppDbContext _context;

        public AccountRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<Account> GetAccountByIDNo(string id)
        {
            return await _context.Accounts.SingleOrDefaultAsync(a => a.IDNumber == id);
        }

        public async Task<Account> GetAccountByUsernamePassword(string username, string password)
        {
            return await _context.Accounts.SingleOrDefaultAsync(a => a.username == username && a.password == password);
        }

    }
}
