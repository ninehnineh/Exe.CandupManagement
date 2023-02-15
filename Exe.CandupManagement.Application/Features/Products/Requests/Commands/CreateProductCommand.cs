using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Requests.Commands
{
    public class CreateProductCommand : IRequest<BaseCommandResponse>
    {
        public CreateProductDto CreateProductDto { get; set; }
    }
}
