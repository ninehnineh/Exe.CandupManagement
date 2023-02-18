using Exe.CandupManagement.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.DTOs.Product.Validators
{
    public class SearchProductByNameDtoValidator : AbstractValidator<SearchProductByNameDto>
    {

        public SearchProductByNameDtoValidator()
        {
            RuleFor(x => x.ProductName)
                .NotEmpty().WithMessage("{PropertyName} must be present")
                .NotNull();
        }
    }
}
