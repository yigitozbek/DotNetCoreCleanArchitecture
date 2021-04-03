using Nightrain.Base.Core.Entities;
using System;

namespace Nightrain.BookStore.Domain.Entities
{
    public class Author : AuditedEntity<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Biography { get; set; }
        public DateTime Birthday { get; set; }
    }
}
