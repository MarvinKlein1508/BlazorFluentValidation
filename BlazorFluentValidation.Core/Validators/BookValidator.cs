using BlazorFluentValidation.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFluentValidation.Core.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(book => book.Title)
                .NotEmpty()
                .MaximumLength(30);

            RuleFor(book => book.Chapters)
                .Must(CheckChapterAmount)
                .WithMessage("The book must contain at least three chapters.");

            RuleForEach(book => book.Chapters)
                .SetValidator(new ChapterValidator());
        }

        protected bool CheckChapterAmount(List<Chapter> chapters)
        {
            return chapters.Count > 2;
        }
    }

}
