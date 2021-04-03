using Nightrain.Base.Core.Entities;

namespace Nightrain.BookStore.Domain.Entities
{
    public class Publisher : AuditedEntity<int>
    {
        public string Name { get; set; }
    }
}
