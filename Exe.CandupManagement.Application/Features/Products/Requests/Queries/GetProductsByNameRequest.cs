using Exe.CandupManagement.Application.DTOs.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Requests.Queries
{
    public class GetProductsByNameRequest : IRequest<IEnumerable<ProductListDto>>
    {
        public SearchProductByNameDto SearchProductByNameDto { get; set; }
    }
}
