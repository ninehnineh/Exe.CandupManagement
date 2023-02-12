using Exe.CandupManagement.Application.Contracts.Persistence;
using Exe.CandupManagement.Domain.Entities;
using Exe.CandupManagement.Persistence.Repositories.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly CandupManagementDbContext _dbContext;

        public ProductRepository(CandupManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
