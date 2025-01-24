using System;
using System.IO;

namespace Files._8._4
{
    class Program
    {
        public static void Main()
        {
            // сохраняем путь к файлу (допустим, вы его скачали на рабочий стол)
            string filePath = "C:/Users//Desktop/BinaryFile.bin";

            // при запуске проверим, что файл существует
            if (File.Exists(filePath))
            {
                // строковая переменная, в которую будем считывать данные
                string stringValue;

                // считываем, после использования высвобождаем задействованный ресурс BinaryReader
                using BinaryReader reader = new(File.Open(filePath, FileMode.Open));
                stringValue = reader.ReadString();
                
                // Вывод
                Console.WriteLine("Из файла считано:");
                Console.WriteLine(stringValue);
                Console.ReadKey();
                }
        }
    }
}