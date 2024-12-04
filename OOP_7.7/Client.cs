
class Client : User
{
    protected override string Name
    {
        get;
        set
        {
            if (value.Length >= 2)
            {
                Name = value;
            }
            else
            { 
                Console.WriteLine("Имя должно содержать два и более символа")
            }
        }
    }

    protected string Email;

    protected string Phone;

    protected string? Address;

    public Client(string name,
                  string email,
                  string phone,
                  string? address)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
    }

    public override void Print()
    {
        Console.WriteLine($"Клиент: {Name}, Email клиента: {Email}," +
            $"тел. клиента: {Phone}, адресс клиента {Address}");
    }
}
