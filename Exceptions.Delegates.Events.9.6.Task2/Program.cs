
namespace Exceptions.Delegates.Events._9._6.Task2;

class MainClass
{
    public static void Main(string[] args)
    {
        ArraySorter arraySorter = new ArraySorter();
        arraySorter.ArraySortedEvent += ShowSortedArray;
        
        string[] surnames = ["Сидоров", "Петров", "Тихонова", "Борисова", "Иванова"];
        
        while (arraySorter.Number is null)
        {
            try
            {
                arraySorter.SetSortingNumber();
                arraySorter.SortArray(surnames);
            }
            catch (EnteredNumberException)
            {
                Console.WriteLine("Введено некорректное значение!");
            }
        }
    }
    
    static void ShowSortedArray(string[] array)
    {
        foreach (string str in array)
        {
            Console.Write($"{str} ");
        }
    }
}
