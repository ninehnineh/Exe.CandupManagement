using AutoMapper;
using Exe.CandupManagement.Application.Contracts.Persistence;
using Exe.CandupManagement.Application.DTOs.Product.Validators;
using Exe.CandupManagement.Application.Features.Products.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Handlers.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository,
            IMapper mapper,
            ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateProductDtoValidator(_categoryRepository);
            var validationResult = await validator.ValidateAsync(request.UpdateProductDto);

            if (validationResult.IsValid == false)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var product = await _productRepository.GetAsync(request.Id);

            if (request.UpdateProductDto != null)
            {
                _mapper.Map(request.UpdateProductDto, product);

                await _productRepository.Update(product);
            }
            //else if (request.ChangeProductStatusDto != null)
            //{
            //    await _productRepository.ChangeApprovalStatus(product, request.ChangeProductStatusDto.IsAvailable);
            //}

            return Unit.Value;
        }
    }
}
