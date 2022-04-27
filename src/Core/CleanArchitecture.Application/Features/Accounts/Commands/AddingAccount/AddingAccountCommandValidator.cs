using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CleanArchitecture.Application.Features.Accounts.Commands.AddingAccount
{
    internal class AddingAccountCommandValidator : AbstractValidator<AddingAccountCommand>
    {
        public AddingAccountCommandValidator()
        {
            //RuleFor(p => p.Name)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .NotNull()
            //    .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            //RuleFor(p => p.Description)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .NotNull()
            //    .MaximumLength(500).WithMessage("{PropertyName} must not exceed 500 characters.");

        }
    }
}
