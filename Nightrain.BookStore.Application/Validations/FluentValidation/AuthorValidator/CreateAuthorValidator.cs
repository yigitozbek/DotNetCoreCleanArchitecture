using FluentValidation;
using Nightrain.BookStore.Domain.Commands.AuthorCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nightrain.BookStore.Application.Validations.FluentValidation.AuthorValidator
{
    public class CreateAuthorValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorValidator()
        {
            RuleFor(i => i.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(i => i.Surname)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(i => i.Biography)
                .NotNull()
                .NotEmpty();

            RuleFor(i => i.Birthday)
                .NotNull()
                .NotEmpty();

        }
    }
}
