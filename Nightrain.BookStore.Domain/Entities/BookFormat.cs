using Nightrain.Base.Core.Entities;

namespace Nightrain.BookStore.Domain.Entities
{
    public class BookFormat : Entity<int>
    {
        public string Name { get; set; }
    }
}
