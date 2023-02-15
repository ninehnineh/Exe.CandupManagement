using Exe.CandupManagement.Application.Contracts.Persistence.Generic;
using Exe.CandupManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Contracts.Persistence
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task ChangeApprovalStatus(Product Product, bool ApprovalStatus);

    }
}
