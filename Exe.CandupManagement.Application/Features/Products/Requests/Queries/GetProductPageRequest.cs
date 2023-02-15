using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Requests.Queries
{
    public class GetProductPageRequest : IRequest<PagedResult<ProductListDto>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

    }
}
