using AutoMapper;
using Exe.CandupManagement.Application.Contracts.Persistence;
using Exe.CandupManagement.Application.DTOs.Product;
using Exe.CandupManagement.Application.Features.Products.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Handlers.Queries
{
    public class GetProductListRequestHandler : IRequestHandler<GetProductListRequest, IEnumerable<ProductListDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductListRequestHandler(IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductListDto>> Handle(GetProductListRequest request, CancellationToken cancellationToken)
        {
            var productRequests = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductListDto>>(productRequests);
        }
    }
}
