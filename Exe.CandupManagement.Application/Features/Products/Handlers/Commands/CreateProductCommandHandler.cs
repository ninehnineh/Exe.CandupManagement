using AutoMapper;
using Exe.CandupManagement.Application.Contracts.Persistence;
using Exe.CandupManagement.Application.DTOs.Product.Validators;
using Exe.CandupManagement.Application.Features.Products.Requests.Commands;
using Exe.CandupManagement.Application.Responses;
using Exe.CandupManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Features.Products.Handlers.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, BaseCommandResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IHostingEnvironment _environment;

        public CreateProductCommandHandler(IProductRepository productRepository,
            IMapper mapper,
            ICategoryRepository categoryRepository,
            IHostingEnvironment environment)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _categoryRepository = categoryRepository;
            _environment = environment;
        }

        public async Task<BaseCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateProductDtoValidator(_categoryRepository);
            var validationResult = await validator.ValidateAsync(request.CreateProductDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Create Failed";
                response.Errors = validationResult.Errors
                    .Select(q => q.ErrorMessage)
                    .ToList();
            }
            else
            {

                var product = _mapper.Map<Product>(request.CreateProductDto);

                if (request.Image != null)
                {
                    var filePath = Path.Combine(_environment.ContentRootPath, @"UploadFile", request.Image.FileName);
                    using var fileStream = new FileStream(filePath, FileMode.Create);
                    await request.Image.CopyToAsync(fileStream);
                    product.Image = request.Image.FileName;
                    product.IsAvailable = true;
                }

                product = await _productRepository.AddAsync(product);

                response.Success = true;
                response.Message = "Creation Successful";
                response.Id = product.Id;
            }

            return response;
        }
    }
}
