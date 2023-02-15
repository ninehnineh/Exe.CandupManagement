using Exe.CandupManagement.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.DTOs.Product.Validators
{
    public class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
    {
        private readonly ICategoryRepository _categoryRepository;

        public CreateProductDtoValidator(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            Include(new ProductDtoValidator(_categoryRepository));

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
