﻿using System;

namespace Nightrain.BookStore.Domain.Commands.AuthorCommand
{
    public class UpdateAuthorCommand : AuthorCommandBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Biography { get; set; }
        public DateTime Birthday { get; set; }
    }
}
