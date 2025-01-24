
using System;
using Exceptions;

class MainClass
{
    public static void Main(string[] args)
    {

        Exception[] test = new Exception[3] { new testEx(null, null), new testEx("s", 2), new ArgumentException() }; // { ArgumentException, NullReferenceException }
        //test[0] = new testEx("w", 1);
        //test[1] = new testEx("s", 2);
        //test[1] = new NameMinLengthException("w", 1);

        try
        {
            Person person = new Person { Name = "Tom", Age = 16 };
            //Object[] test = new Object[2] { LegalAgeException, NameMinLengthException };
        }
        catch (LegalAgeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine($"Некорректное значение: {ex.Value}");
            Console.ReadLine();
        }
        catch (NameMinLengthException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine($"Длина введённого имени: {ex.NameLength}");
            Console.ReadLine();
        }
    }
}

public class testEx : ArgumentException
{
    public int? Value { get; }
    public testEx(string? message, int? val)
        : base(message)
    {
        Value = val;
    }
}