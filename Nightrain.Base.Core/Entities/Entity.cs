using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nightrain.Base.Core.Entities
{
    public class Entity<TType> : IEntity<TType>
    {
        public TType Id { get; set; }

    }
}
