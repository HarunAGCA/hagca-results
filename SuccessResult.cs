namespace Hagca.Results;

public class SuccessResult : BaseResult
{
    public SuccessResult() : this(messages: new())
    {

    }

    public SuccessResult(List<string> messages) : base(isSuccess: true, messages: messages)
    {

    }
}