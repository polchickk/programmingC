using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            var n = int.Parse(Console.ReadLine());
            
            int sum = 0;

            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }

            Console.WriteLine($"Сумма цифр числа: {sum}");

            Console.ReadKey();

        }
    }
}
