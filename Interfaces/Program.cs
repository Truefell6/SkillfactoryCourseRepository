
namespace Interfaces
{
    class Program 
    {   
        static ILogger Logger { get; set; }
        static void Main()
        {
            Logger = new Logger();
            var calculator = new Calculator(Logger);
            
            calculator.Sum();
        }
    }

    public class Calculator: ICalculator
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public void Sum()
        {
            var first_digit = 0;
            var second_digit = 0;
            bool is_conversion_successful = false;
            while (!is_conversion_successful)
            {
                try
                {
                    Console.WriteLine("Please enter first number:");
                    first_digit = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Please enter second number:");
                    second_digit = int.Parse(Console.ReadLine()!);
                    is_conversion_successful = true;
                }
                catch (Exception e)
                {
                    Logger.Error(e.Message);
                    is_conversion_successful = false;
                }
            }
            
            Logger.Event("Sum of " + first_digit + " and " + second_digit + " is " + (first_digit + second_digit).ToString());
        }
    }

    public interface ICalculator
    {
        void Sum();
    }

    public class Logger : ILogger
    {
        public void Event(string message)
        {   
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}