namespace Nightrain.Base.Core.Helpers.Results
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }

}
