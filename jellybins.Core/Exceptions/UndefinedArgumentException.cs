namespace jellybins.Core.Exceptions;

public class UndefinedArgumentException : Exception
{
    public UndefinedArgumentException(int value)
    {
        Message = $"Значение {value} документально не определено.";
    }

    public override string Message { get; }
}