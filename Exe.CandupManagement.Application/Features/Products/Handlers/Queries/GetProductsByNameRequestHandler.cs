using AutoMapper;
using Exe.CandupManagement.Application.Contracts.Persistence;
using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Application.DTOs.Product.Validators;
using Exe.CandupManagement.Application.Exceptions;
using Exe.CandupManagement.Application.Features.Products.Requests.Queries;
using Exe.CandupManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Handlers.Queries
{
    public class GetProductsByNameRequestHandler : IRequestHandler<GetProductsByNameRequest, IEnumerable<ProductListDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsByNameRequestHandler(IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductListDto>> Handle(GetProductsByNameRequest request, CancellationToken cancellationToken)
        {
            //var validator = new SearchProductByNameDtoValidator();
            //var validationResult = await validator.ValidateAsync(request.SearchProductByNameDto);

            //if (validationResult.IsValid == false)
            //{
            //    throw new NotFoundException(nameof(Product), request.)
            //}

            var products = await _productRepository.SearchProductsByName(request.SearchProductByNameDto);
            return _mapper.Map<IEnumerable<ProductListDto>>(products);
        }
    }
}
