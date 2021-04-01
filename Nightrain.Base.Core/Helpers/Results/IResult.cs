namespace Nightrain.Base.Core.Helpers.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
