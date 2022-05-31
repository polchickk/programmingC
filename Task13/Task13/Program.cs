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
        private static readonly Dictionary<int, string> birthdays = new Dictionary<int, string>()
        {
            {1, "Январь"},
            {2, "Февраль"},
            {3, "Март"},
            {4, "Апрель"},
            {5, "Май"},
            {6, "Июнь"},
            {7, "Июль"},
            {8, "Август"},
            {9, "Сентябрь"},
            {10, "Октябрь"},
            {11, "Ноябрь"},
            {12, "Декабрь"}
        };

        static void Main(string[] args)
        {
            var name = GetPerson("Введите имя");
            var path=Reade
            var index = GetIndexFromFile("birthday.txt");

            PrintTable(index[name]);
            Console.ReadKey();
        }

        public static Dictionary<string, Dictionary<string, long>> GetIndexFromFile(string pathToFile)
        {

            var res = new Dictionary<string, Dictionary<string, long>>();
            using (var file = new StreamReader("birthdays.txt", Encoding.Default))
            {
                while (!file.EndOfStream)
                {
                    var (month, name) = GetMonthAndName(file.ReadLine());
                    if (!res.ContainsKey(name))
                        res[name] = new Dictionary<string, long>();
                    if (!res[name].ContainsKey(month))
                    {
                        res[name][month] = 1;
                        continue;
                    }

                    res[name][month]++;

                }
            }

            return res;
        }
        public static void PrintTable(Dictionary<string, long> birthdays)
        {
            Console.WriteLine("Месяц    Количество человек, в нем рожденных");
            foreach (var month in birthdays.Keys)
                foreach (var count in birthdays.Values)
                    Console.WriteLine($"{month}\t{count}");

        }
        private static (string, string) GetMonthAndName(string str)
        {
            var raw = str.Split('\t');
            var (date, name) = (raw[0], raw[1]);
            var monthInt = DateTime.Parse(date).Month;
            var month = GetTextMonth(monthInt);
            return (month, name);
        }

        private static string GetTextMonth(int month) => birthdays[month];
        static bool IsCorrectPerson(string name)
        {
            return birthdays.ContainsValue(name);
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





