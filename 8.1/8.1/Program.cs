using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное значение аргумента");
            var n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (var i = 1; i <= n; i++)
                sum += (i + 1) / i;

            Console.WriteLine($"Результат: {sum}");

            Console.ReadKey();
        }
    }
}
