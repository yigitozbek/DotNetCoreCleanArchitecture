using System;

namespace Nightrain.BookStore.Application.DataTransferObjects.Author
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Biography { get; set; }
        public DateTime Birthday { get; set; }
    }
}
