using Exe.CandupManagement.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.DTOs.Product.Validators
{
    public class ProductDtoValidator : AbstractValidator<IProductDto>
    {
        private readonly ICategoryRepository _categoryRepository;

        public ProductDtoValidator(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            RuleFor(p => p.ProductName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThanOrEqualTo(0).WithMessage("{PropertyName} must greater than or equal to {ComparisonValue}");

            RuleFor(p => p.CategoryId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {
                    var categoryExists = await _categoryRepository.Exists(id);
                    return categoryExists;
                })
                .WithMessage("{PropertyName} does not exist");

            RuleFor(x => x.Description)
                .MaximumLength(200).WithMessage("{PropertyName} must be less than or equal to 200 characters");
        }
    }
}
