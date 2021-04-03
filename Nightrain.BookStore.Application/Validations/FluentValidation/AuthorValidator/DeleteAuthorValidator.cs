using FluentValidation;
using Nightrain.BookStore.Application.Commands.AuthorCommand;

namespace Nightrain.BookStore.Application.Validations.FluentValidation.AuthorValidator
{
    public class DeleteAuthorValidator : AbstractValidator<DeleteAuthorCommand>
    {
        public DeleteAuthorValidator()
        {
      

        }
    }
}
