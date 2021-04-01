using Nightrain.Base.Core.Entities;

namespace Nightrain.BookStore.Domain.Entities
{
    public class Category : AuditedEntity<int>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
    }
}
