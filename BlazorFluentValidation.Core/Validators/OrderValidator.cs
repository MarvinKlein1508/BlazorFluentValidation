using BlazorFluentValidation.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Core.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(order => order.Model)
                .NotEmpty()
                .MaximumLength(30);

            RuleFor(order => order.Quanitity)
                .GreaterThan(0)
                .LessThan(10);

            RuleFor(order => order.Total)
                .GreaterThan(125.5m);

            RuleFor(order => order.Customer)
                .SetValidator(new CustomerValidator());
        }
    }
}
