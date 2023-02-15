﻿using Exe.CandupManagement.Application.DTOs.Product;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Requests.Commands
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public UpdateProductDto UpdateProductDto { get; set; }

    }
}
