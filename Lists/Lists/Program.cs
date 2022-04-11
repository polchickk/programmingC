using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 5, 0 };
            var lines = new List<string>();

            lines.Add("первая строка");
            lines.Add("вторая строка");

            numbers[1] = 7;
            var n = numbers[0] + numbers[1];
            Console.WriteLine($"n = {n}");

            Console.WriteLine($"numbers capacity = {numbers.Capacity}");
            numbers.Add(9);
            Console.WriteLine($"numbers capacity = {numbers.Capacity}");

            numbers.Insert(2, 4);//2 index,4 number
            numbers.Add(4);

            Console.WriteLine($"Первое вхождение \"4\" по индексу {numbers.IndexOf(4)}");
            Console.WriteLine($"Последнее вхождение \"4\" по индексу {numbers.LastIndexOf(4)}");
            Console.WriteLine($"Первое вхождение \"44\" по индексу {numbers.IndexOf(44)}");

            // numbers.Remove(4);
            numbers.RemoveAt(6);
            numbers.RemoveAt(4);

            var answer = numbers.Contains(1) ? "yes":"no";
            Console.WriteLine($"Есть ли в списке 1? {answer}");

            answer = numbers.Contains(11) ? "yes" : "no";
            Console.WriteLine($"Есть ли в списке 11? {answer}");

            numbers.Clear();

            Console.ReadKey();

        }
    }
}
