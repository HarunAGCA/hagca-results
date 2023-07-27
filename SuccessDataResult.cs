namespace Hagca.Results;

public sealed class SuccessDataResult<T> : SuccessResult
{
    public T Data { get; private set; }
    public SuccessDataResult(T data)
    {
        Data = data;
    }

    public SuccessDataResult(T data, List<string> messages) : base(messages:messages)
    {
        Data = data;
    }

}