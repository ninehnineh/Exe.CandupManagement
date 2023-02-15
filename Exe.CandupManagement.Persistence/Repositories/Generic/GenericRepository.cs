using Exe.CandupManagement.Application.Contracts.Persistence.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Persistence.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CandupManagementDbContext _dbContext;

        public GenericRepository(CandupManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual async Task<T> AddAsync(T Entity)
        {
            await _dbContext.AddAsync(Entity);
            await _dbContext.SaveChangesAsync();
            return Entity;
        }

        public virtual async Task DeleteAsync(T Entity)
        {
            _dbContext.Set<T>().Remove(Entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<bool> Exists(int Id)
        {
            var entity = await GetAsync(Id);
            return entity != null;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetAsync(int Id)
        {
            return await _dbContext.Set<T>().FindAsync(Id);
        }

        public virtual async Task Update(T Entity)
        {
            _dbContext.Entry(Entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
