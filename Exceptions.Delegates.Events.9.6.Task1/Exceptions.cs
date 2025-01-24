
namespace Exceptions;

using System;

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
    public int NameLength;
    public NameMinLengthException(string message, string name)
        : base(message)
    { 
        NameLength = name.Length;
    }
}
