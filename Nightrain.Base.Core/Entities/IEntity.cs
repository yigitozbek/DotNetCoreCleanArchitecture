namespace Nightrain.Base.Core.Entities
{
    public interface IEntity<TType>
    {
        TType Id { get; set; }
    }
}