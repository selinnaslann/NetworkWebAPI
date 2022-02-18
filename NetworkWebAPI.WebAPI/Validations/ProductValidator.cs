using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using NetworkWebAPI.WebAPI.Entities;
using NetworkWebAPI.WebAPI.Entities.ViewModels;

namespace NetworkWebAPI.WebAPI.Validations
{
    public class ProductValidator : AbstractValidator<PostProductQueryViewModel>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().MinimumLength(3).MaximumLength(20);

            RuleFor(p => p.CategoryId).LessThanOrEqualTo(100).NotEmpty();

            RuleFor(p => p.StockAmount).NotEmpty().GreaterThan(0);

        }
    }
}
