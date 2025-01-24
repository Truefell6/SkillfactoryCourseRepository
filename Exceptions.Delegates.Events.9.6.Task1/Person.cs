
using System;
using Exceptions;

class Person
{
    private string name;
    public required string Name
    {
        get => name;

        set
        {
            if (value.Length <= 1)
            {
                throw new NameMinLengthException("Имя не может состоять из одной буквы", value);
            }
            else
            {
                name = value;
            }
        }
    }
    private int age;
    private readonly int LegalAge = 18;
    public required int Age
    {
        get => age;
        set
        {
            if (value <= LegalAge)
                throw new LegalAgeException($"Возраст должен быть больше {LegalAge}", value);
            else
                age = value;
        }
    }
}
