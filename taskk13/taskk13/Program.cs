using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        private static readonly Dictionary<int, string> months = new Dictionary<int, string>()
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

        private static Dictionary<string, Dictionary<string, long>> index;
        private static readonly CultureInfo parsingCulture = new CultureInfo("ru");
        static void Main(string[] args)
        {
            index = GetIndexFromFile();

            while (true)
            {
                var name = GetPerson("Введите имя");

                PrintTable(index[name]);
            }

        }

        public static Dictionary<string, Dictionary<string, long>> GetIndexFromFile()
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
            foreach (var pair in birthdays)
                Console.WriteLine($"{pair.Key}\t{pair.Value}");

        }
        private static (string, string) GetMonthAndName(string str)
        {
            var raw = str.Split('\t');
            var (date, name) = (raw[0], raw[1]);
            var monthInt = DateTime.Parse(date, parsingCulture).Month;
            var month = GetTextMonth(monthInt);
            return (month, name);
        }

        private static string GetTextMonth(int month) => months[month];
        static bool IsCorrectPerson(string name)
        {
            return index.ContainsKey(name);
        }
        static string GetPerson(string message)
        {
            string name;

            while (true)
            {
                Console.WriteLine(message);
                name = Console.ReadLine();

                if (name == "" || !IsCorrectPerson(name))
                {
                    Console.WriteLine($"Персонажа {name} нет");
                    continue;
                }

                return name;
            }

        }
    }
}
