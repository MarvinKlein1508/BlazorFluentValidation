using BlazorFluentValidation.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Core.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.FirstName)
                .NotEmpty().WithMessage("Vorname darf nicht leer sein")
                .MaximumLength(50);

            RuleFor(customer => customer.LastName)
                .NotEmpty().WithMessage("Nachname darf nicht leer sein")
                .MaximumLength(50);

        }
    }
}
