
public class Product
{
    public required string Name;

    public required int Count
    {
        get
        {
            return Count;
        }

        set
        {
            if (value >= 0)
            {
                Count = value;
            }
        }
    }

    public string? Description;
    
    public Product(string name,
                   int count,
                   string? description)
    {
        Name = name;
        Count = count;
        Description = description;
    }

    public void Print()
    {
        Console.WriteLine($"Продукт: {Name}, количество: {Count}, описание: {Description}");
    }

    public int DecreaseProductCount(in int amount)
    { 
        return this.Count = this.Count - amount;
    }
}
