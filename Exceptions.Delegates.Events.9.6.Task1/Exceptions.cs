
using System.Diagnostics.CodeAnalysis;

namespace Exceptions.Delegates.Events._9._6.Task1;

public class LegalAgeException : ArgumentException
{
    public int Value { get; }
    public LegalAgeException(string message, int val)
        : base(message)
    {
        Value = val;
    }
}

public class NameMinLengthException : ArgumentException
{
    private string? Name { get; }
    public readonly int NameLength;
    public NameMinLengthException(string message, string? name)
        : base(message)
    {
        Name = name;
        NameLength = Name.Length;
    }
}