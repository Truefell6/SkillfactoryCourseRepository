
using System.Runtime.InteropServices.JavaScript;

namespace Exceptions.Delegates.Events._9._6.Task2;

class ArraySorter
{
    public delegate void ArraySortedDelegate(string[] array);
    public event ArraySortedDelegate ArraySortedEvent;
    
    private static int? _number;
    public int? Number
    {
        get => _number;
        set
        {
            if (value != 1 && value != 2) throw new EnteredNumberException("", value);
            _number = value;
        }
    }

    public void SetSortingNumber()
    {
        Console.WriteLine();
        Console.WriteLine("Необходимо ввести 1 для сортировки \"от А до Я\" или 2 для сортировки от \"Я до \"А:");
        
        Number = Convert.ToInt32(Console.ReadLine());
    }

    public void SortArray(string[] array)
    {
        string[] newArray = array;
        
        switch (_number)
        {
            case 1:
                Array.Sort(newArray);
                break;
            case 2:
                Array.Sort(newArray);
                Array.Reverse(newArray);
                break;
        }
        ArraySorted(newArray);
    }

    protected virtual void ArraySorted(string[] array)
    {
        ArraySortedEvent?.Invoke(array);
    }
}