using System;

namespace Hagca.Results;

public abstract class BaseResult
{
    protected BaseResult(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }

    protected BaseResult(bool isSuccess, List<string> messages) : this(isSuccess)
    {
        ArgumentNullException.ThrowIfNull(messages, nameof(messages));
        Messages = messages;
    }
    public bool IsSuccess { get; protected set; }
    public List<string> Messages { get; protected set; } = new();
}
