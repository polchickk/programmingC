using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static Dictionary<string, string> birthdays = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            GetPerson("Введите имя");
            Initialize();

            var months = new List<string> { "январь","февраль","март",
            "апрель","май","июнь","июль","август","сентябрь","октябрь","ноябрь","декабрь"};

            using (var file = new StreamReader("birthdays.txt", Encoding.Default))
            {
                while (!file.EndOfStream)
                {

                }
            }
        }
        static void Initialize()
        {
            string filename;
           
            while (true)
            {
                Console.WriteLine("Введите имя файла");

                filename = Console.ReadLine();

                if (filename == string.Empty) return;

                if (File.Exists(filename))
                    break;
                else
                    Console.WriteLine("Такого файла нет.\n");
            }
            using (var file = new StreamReader(filename, Encoding.Default))
            {
                while (!file.EndOfStream)
                {
                    string[] record = file.ReadLine().Split('-');
                    birthdays[record[1].Trim()] = record[0].Trim();
                }
            }
        }
        static bool IsCorrectPerson(string name)
        {
            return birthdays.ContainsKey(name) || birthdays.ContainsValue(name);
        }
        static string GetPerson(string message)
        {
            string name;

            while (true)
            {
                Console.WriteLine(message);
                name = Console.ReadLine();

                if (name != "" && !IsCorrectPerson(name))
                {
                    Console.WriteLine($"Персонажа {name} нет");
                    continue;
                }

                return name;
            }

        }
    }
}
