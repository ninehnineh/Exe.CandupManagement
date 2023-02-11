using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Contracts.Persistence.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int Id);
        Task<bool> Exists(int Id);
        Task<T> AddAsync(T Entity);
        Task DeleteAsync(T Entity);
        Task Update(T Entity);

    }
}
