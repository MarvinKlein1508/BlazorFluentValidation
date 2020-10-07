using BlazorFluentValidation.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Core.Validators
{
    public class ChapterValidator : AbstractValidator<Chapter>
    {
        public ChapterValidator()
        {
            RuleFor(chapter => chapter.Name)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(chapter => chapter.Pages)
                .GreaterThan(0);
        }
    }
}
