
namespace Exceptions.Delegates.Events._9._6.Task1;

class MainClass
{
    // Не понятно, как вызывать из коллекции исключений эти самые исключения таким образом, чтобы передать в них необходимые аргументы.
    // В модуле такого примера нет, и не понятна цель такого действия, когда есть фильтры исключений.
    // Если есть возможность, просьба привести примеры и указать ресурсы, где можно ознакомиться с таким примером использования массива исключений.
    // Также хотелось бы, чтобы в будущем такие примеры разбирались в модулях.
    public static void Main(string[] args)
    {
        Person[] people = [new Person { Name = "Tom", Age = 16 }, new Person { Name = "D", Age = 24 }, new Person { Name = null, Age = 20 }];
        foreach (var person in people)
        {
            try
            {
                if (person.Name is null)
                {
                    throw new ArgumentNullException(person.Name, "Имя не может быть пустым");
                }
                else if (person.Name.Length <= 1)
                {
                    throw new NameMinLengthException("Имя не может состоять из одной буквы", person.Name);
                }
                else if (person.Age < 18)
                {
                    throw new LegalAgeException("Возраст должен быть не меньше 18", person.Age);
                }
            }
            catch (Exception ex) when ((ex is ArgumentNullException) ||
                                       (ex is NameMinLengthException) ||
                                       (ex is LegalAgeException))
            {
                Console.WriteLine($"С записью человека {person.Name} возникла следующая ошибка: {ex.Message}");
            }
        }
    }
}