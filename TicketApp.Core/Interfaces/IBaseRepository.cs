using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Core.Entities;

namespace TicketApp.Core.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(T _object);
        Task<T> Update(T _object);
        Task DeleteById(int id);
        
    }
}
