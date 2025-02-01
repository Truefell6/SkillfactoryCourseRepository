
namespace Exceptions.Delegates.Events._9._6.Task2;

public class EnteredNumberException : FormatException
{
    public int? Value { get; }
    public EnteredNumberException(string? message, int? val)
        : base(message)
    {
        Value = val;
    }
}