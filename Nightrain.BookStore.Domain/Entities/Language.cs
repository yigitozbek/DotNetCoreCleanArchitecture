using Nightrain.Base.Core.Entities;

namespace Nightrain.BookStore.Domain.Entities
{
    public class Language : Entity<int>
    {
        public string Name { get; set; }
    }
}
