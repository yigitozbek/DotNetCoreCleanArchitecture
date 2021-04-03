using System.Collections.Generic;
using MediatR;
using Nightrain.BookStore.Application.DataTransferObjects.Author;

namespace Nightrain.BookStore.Application.Queries.AuthorQuery
{
    public class GetListAuthorQuery : IRequest<List<AuthorDto>>
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
