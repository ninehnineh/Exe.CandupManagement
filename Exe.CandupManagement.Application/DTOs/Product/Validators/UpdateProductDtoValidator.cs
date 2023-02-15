using Exe.CandupManagement.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.DTOs.Product.Validators
{
    public class UpdateProductDtoValidator : AbstractValidator<UpdateProductDto>
    {
        private readonly ICategoryRepository _categoryRepository;

        public UpdateProductDtoValidator(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            Include(new ProductDtoValidator(_categoryRepository));

            RuleFor(p => p.Id)
                .NotNull().WithMessage("{PropertyName} must be present");

        }
    }
}
