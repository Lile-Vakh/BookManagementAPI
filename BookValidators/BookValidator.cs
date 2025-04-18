using BookManagementAPI.Models;
using FluentValidation;

namespace BookManagementAPI.BookValidators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(book => book.Title)
                .NotEmpty().WithMessage("Title is required")
                .MaximumLength(100).WithMessage("Title must be at most 100 characters");

            RuleFor(book => book.Author)
                .NotEmpty().WithMessage("Author is required");

            RuleFor(book => book.Year)
                .InclusiveBetween(1800, 2100).WithMessage("Year must be between 1800 and 2100");
        }
    }
}