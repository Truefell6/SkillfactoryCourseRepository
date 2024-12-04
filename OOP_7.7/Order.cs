
class Order<T>
{
    public T Number = default(T);

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    // ... Другие поля
}