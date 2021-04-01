using Nightrain.Base.Core.Entities;

namespace Nightrain.BookStore.Domain.Entities
{
    public class Cover : AuditedEntity<int>
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        public short Queue { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
