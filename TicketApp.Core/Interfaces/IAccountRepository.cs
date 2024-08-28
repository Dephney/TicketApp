using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Core.Entities;

namespace TicketApp.Core.Interfaces
{
    public interface IAccountRepository: IBaseRepository<Account>
    {
        Task<Account> GetAccountByIDNo(string id);
        Task<Account> GetAccountByUsernamePassword(string username, string password);
        

    }
}
