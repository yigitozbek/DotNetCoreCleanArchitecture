using Nightrain.Base.Core.Entities;
using System.Collections.Generic;

namespace Nightrain.BookStore.Domain.Entities
{
    public class Publisher : AuditedEntity<int>
    {
        public string Name { get; set; }
    }
}
