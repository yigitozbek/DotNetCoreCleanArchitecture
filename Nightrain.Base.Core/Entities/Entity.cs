namespace Nightrain.Base.Core.Entities
{
    public class Entity<TType> : IEntity<TType>
    {
        public TType Id { get; set; }

    }
}
