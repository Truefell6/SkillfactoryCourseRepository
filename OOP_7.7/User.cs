
abstract class User
{
    private Client client;

    public User()
    {
        client = new Client();
    }

    public virtual required string Name { get; set; };

    public void Print()
    {
        Console.WriteLine($"Клиент: {Name});
    }
}
