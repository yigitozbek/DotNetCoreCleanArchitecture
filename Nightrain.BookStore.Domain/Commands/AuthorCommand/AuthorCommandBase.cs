using Nightrain.Base.Core.Commands;

namespace Nightrain.BookStore.Domain.Commands.AuthorCommand
{
    public class AuthorCommandBase : CommandBase
    {
        public int Id { get; set; }
    }
}
