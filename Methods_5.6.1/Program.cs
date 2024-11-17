using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        ShowUserData(GetUserData());

        Console.ReadKey();
    }

    static (string, string, double, bool, int, string[], int, string[]) GetUserData()
    {   
        Console.WriteLine("Введите своё имя:");
        string userName = InputCorrectValue("str");

        Console.WriteLine("Введите свою фамилию:");
        string userLastName = InputCorrectValue("str");

        Console.WriteLine("Введите свой возраст:");
        double age = double.Parse(InputCorrectValue("num"));

        Console.WriteLine("У вас есть питомцы (Да/Нет)?");
        bool hasPet = bool.Parse(InputCorrectValue("bool"));

        int petCount = 0;
        string[] pets = {""};

        if (hasPet)
        {
            Console.WriteLine("Сколько у вас питомцев?");
            petCount = int.Parse(InputCorrectValue("num"));

            Console.WriteLine("Введите имена питомцев одно за другим, разделяя их с помощью клавиши Enter:");
            pets = GetArrayWithKnownLength(petCount);
        }

        Console.WriteLine("Сколько у вас любимых цветов?");
        int favColorsCount = int.Parse(InputCorrectValue("num"));

        Console.WriteLine("Введите названия цветов одно за другим, разделяя их с помощью клавиши Enter:");
        string[] favColors = GetArrayWithKnownLength(favColorsCount);

        var userData = (userName, userLastName, age, hasPet, petCount, pets, favColorsCount, favColors);

        return userData;
    }

    static string InputCorrectValue(in string checkType) //метод, который запрашивает ввод и проверяет введённое значение, при некорректном вводе запрашивает ввод заново
    {
        var checkTypeValues = new List<string>() { "str", "num", "bool" };

        if (String.IsNullOrEmpty(checkType) || checkTypeValues.Contains(checkType) == false)
        {
            throw new Exception("Method \"InputCorrectValue\" requires \"str\", \"num\" or \"bool\" as an argument.");
        }

        var value = "";
        bool isInputCorrect = false;

        while (isInputCorrect == false)
        {
            value = Console.ReadLine();
            bool isValueNum = int.TryParse(value, out int number);

            if (String.IsNullOrEmpty(value))
            {
                continue;
            }

            if (checkType == "str" && isValueNum == false && value.Length > 1)
            {
                isInputCorrect = true;
            }
            else if (checkType == "num" && isValueNum == true && IsPositiveNumber(number) == true)
            {
                isInputCorrect = true;
            }
            else if (checkType == "bool" && isValueNum == false && value.Length >= 2 && value.Length <= 3)
            {
                if (value.ToLower() == "да")
                {
                    value = "true";
                    isInputCorrect = true;
                }
                else if (value.ToLower() == "нет")
                {
                    value = "false";
                    isInputCorrect = true;
                }
            }
            
            if (isInputCorrect == false)
            {
                string typeOutput = "";
                if (checkType == "str")
                {
                    typeOutput = "строковое значение";
                }
                else if (checkType == "num")
                {
                    typeOutput = "число больше нуля";
                }
                else if (checkType == "bool")
                {
                    typeOutput = "\"Да\" или \"Нет\"";
                }
                Console.WriteLine($"Введено некорректное значение, необходимо ввести {typeOutput}.");
                continue;
            }
        }
        return value;
    }

    static bool IsPositiveNumber(in int number) //метод, который проверяет, является ли введённое значение числом больше нуля
    {
        if (number > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static string[] GetArrayWithKnownLength(in int arrayLength) //метод, который заполняет данные с клавиатуры с заранее известной длиной массива
    {
        var arrayWithKnownLength = new string[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            arrayWithKnownLength[i] = InputCorrectValue("str");
        }

        return arrayWithKnownLength;
    }

    static void ShowUserData((string userName, string userLastName, double age, bool hasPet, int petCount, string[] pets, int favColorsCount, string[] favColors) userData) //метод, который показывает данные указанного кортежа
    {
        Console.WriteLine($"Ваше имя: {userData.userName}");
        Console.WriteLine($"Ваша фамилия: {userData.userLastName}");
        Console.WriteLine($"Ваш возраст: {userData.age}");
        if (userData.hasPet)
        {
            Console.WriteLine($"Количество ваших питомцев равно: {userData.petCount}");
            Console.WriteLine("Их имена:");
            var k = 0;
            for (k = 0; k < userData.pets.Length; k++)
            {
                Console.Write($" {userData.pets[k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Ваши любимые цвета:");
        var i = 0;
        for (i = 0; i < userData.favColors.Length; i++)
        {
            Console.Write($" {userData.favColors[i]}");
        }
    }
}