
static void Main(string[] args)
{
    for (int k = 0; k < 3; k++)
    {
        (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) userData;

        Console.WriteLine("Введите имя");
        userData.Name = Console.ReadLine();

        Console.WriteLine("Введите фамилию");
        userData.LastName = Console.ReadLine();

        Console.WriteLine("Введите логин");
        userData.Login = Console.ReadLine();
        userData.LoginLength = userData.Login.Length;

        Console.WriteLine("Есть ли у вас животные? Да или Нет");
        if (Console.ReadLine() == "Да")
        {
            userData.HasPet = true;
        }
        else
        {
            userData.HasPet = false;
        }

        Console.WriteLine("Введите ваш возраст");
        userData.Age = double.Parse(Console.ReadLine());

        userData.favcolors = new string[3];
        Console.WriteLine("Введите три любимых цвета");
        for (int i = 0; i < userData.favcolors.Length; i++)
        {
            userData.favcolors[i] = Console.ReadLine();
        }
    }

    Console.ReadKey();
}
