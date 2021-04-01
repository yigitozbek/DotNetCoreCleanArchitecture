using Nightrain.Base.Core.Entities;

namespace Nightrain.BookStore.Domain.Entities
{
    public class BookCategory : Entity<int>
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
