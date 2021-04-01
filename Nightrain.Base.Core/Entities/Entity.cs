using System.ComponentModel.DataAnnotations;

namespace Nightrain.Base.Core.Entities
{
    public class Entity<TType> : IEntity<TType>
    {
        [Key]
        public TType Id { get; set; }
    }
}
