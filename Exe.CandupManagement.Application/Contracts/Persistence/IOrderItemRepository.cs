using Exe.CandupManagement.Application.Contracts.Persistence.Generic;
using Exe.CandupManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Contracts.Persistence
{
    public interface IOrderItemRepository : IGenericRepository<OrderItem>
    {

    }
}
