using Exe.CandupManagement.Application.Contracts.Persistence.Generic;
using Exe.CandupManagement.Application.Models;
using Exe.CandupManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Contracts.Persistence
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task ChangeApprovalStatus(Product Product, bool ApprovalStatus);
        Task<IEnumerable<Product>> GetAvailableProductAsync();
        Task<PagedResult<Product>> GetPageAsync(int pageNumber, int pageSize);
        new Task<Product> GetAsync(int Id);
        //new Task<IEnumerable<Product>> GetAllAsync();
    }
}
