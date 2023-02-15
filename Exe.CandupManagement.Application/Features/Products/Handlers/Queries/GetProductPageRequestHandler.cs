using AutoMapper;
using Exe.CandupManagement.Application.Contracts.Persistence;
using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Application.Features.Products.Requests.Queries;
using Exe.CandupManagement.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Handlers.Queries
{
    public class GetProductPageRequestHandler : IRequestHandler<GetProductPageRequest, PagedResult<ProductListDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductPageRequestHandler(IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<PagedResult<ProductListDto>> Handle(GetProductPageRequest request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetPageAsync(request.PageNumber, request.PageSize);
            return new PagedResult<ProductListDto>
            {
                PageNumber = products.PageNumber,
                PageSize = products.PageSize,
                TotalItems = products.TotalItems,
                ListItems = _mapper.Map<IEnumerable<ProductListDto>>(products.ListItems)
            };
        }
    }
}
