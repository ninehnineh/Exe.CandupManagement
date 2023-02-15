using AutoMapper;
using Exe.CandupManagement.Application.Contracts.Persistence;
using Exe.CandupManagement.Application.Exceptions;
using Exe.CandupManagement.Application.Features.Products.Requests.Commands;
using Exe.CandupManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Handlers.Commands
{
    public class ChangeProductStatusCommandHandler : IRequestHandler<ChangeProductStatusCommand>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ChangeProductStatusCommandHandler(IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(ChangeProductStatusCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetAsync(request.Id);
            if (product == null)
            {
                throw new NotFoundException(nameof(Product), request.Id);
            }

            await _productRepository.ChangeApprovalStatus(product, request.ChangeProductStatusDto.IsAvailable);

            return Unit.Value;
        }
    }
}
