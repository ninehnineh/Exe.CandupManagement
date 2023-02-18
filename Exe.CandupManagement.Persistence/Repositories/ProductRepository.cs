using Exe.CandupManagement.Application.Contracts.Persistence;
using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Application.Models;
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

        //public override async Task<IEnumerable<Product>> GetAllAsync()
        //{
        //    var products = await _dbContext.Products.Include(x => x.Category).ToListAsync();
        //    return products;
        //}

        public async Task<IEnumerable<Product>> SearchProductsByName(SearchProductByNameDto searchProductByNameDto)
        {
            var products = _dbContext.Products.AsQueryable();

            if (!string.IsNullOrEmpty(searchProductByNameDto.ProductName))
            {
                products = products.Where(x => x.ProductName.ToLower().Trim()
                .Contains(searchProductByNameDto.ProductName.ToLower().Trim()));
            }

            var skip = (searchProductByNameDto.PagedRequest.PageNumber - 1) * searchProductByNameDto.PagedRequest.PageSize;
            products = products.Skip(skip).Take(searchProductByNameDto.PagedRequest.PageSize);

            return await products.ToListAsync();
        }

        public override async Task<Product> GetAsync(int Id)
        {
            var product = await _dbContext.Products.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == Id);
            return product;
        }

        public async Task ChangeApprovalStatus(Product product, bool approvalStatus)
        {
            product.IsAvailable = approvalStatus;
            _dbContext.Entry(product).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAvailableProductAsync()
        {
            var products = await  _dbContext.Products
                .Where(x => x.IsAvailable == true)
                .ToListAsync();
            return products;
        }

        public async Task<PagedResult<Product>> GetPageAsync(int pageNumber, int pageSize)
        {
            var products = _dbContext.Products;
            var totalItems = await products.CountAsync();

            var itemsOnPage = await products.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<Product>
            {
                TotalItems = totalItems,
                PageSize = pageSize,
                PageNumber = pageNumber,
                ListItems = itemsOnPage
            };
        }

        public Task<IEnumerable<Product>> SearchProductsByPrice(SearchProductByPriceDto searchProductByPriceDto)
        {
            throw new NotImplementedException();
        }
    }
}
