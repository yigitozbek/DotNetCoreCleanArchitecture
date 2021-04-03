using System;

namespace Nightrain.BookStore.Application.Commands.AuthorCommand
{
    public class CreateAuthorCommand : AuthorCommandBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Biography { get; set; }
        public DateTime Birthday { get; set; }
    }
}
