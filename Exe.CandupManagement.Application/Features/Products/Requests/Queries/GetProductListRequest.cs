using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Requests.Queries
{
    public class GetProductListRequest : IRequest<IEnumerable<ProductListDto>>
    {
    }
}
