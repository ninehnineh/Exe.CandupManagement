using Exe.CandupManagement.Application.DTOs.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Requests.Commands
{
    public class ChangeProductStatusCommand : IRequest
    {
        public int Id { get; set; }
        public ChangeProductStatusDto ChangeProductStatusDto { get; set; }

    }
}
