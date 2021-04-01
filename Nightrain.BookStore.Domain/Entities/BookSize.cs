using Nightrain.Base.Core.Entities;

namespace Nightrain.BookStore.Domain.Entities
{
    public class BookSize : Entity<int>
    {
        public string Size { get; set; }
    }
}
