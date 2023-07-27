
namespace Hagca.Results;

public class ErrorResult : BaseResult
{
    public ErrorResult(List<string> messages) : base(isSuccess: false, messages: messages)
    {

    }
}