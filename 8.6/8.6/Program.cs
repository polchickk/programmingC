using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i <= (n+1); i++)
            {
                Console.WriteLine(StringСalculation(i));
            }
        
            Console.ReadKey();
        }

        static string StringСalculation(int number)
        {
            while (number > 0)
            {
                Console.Write($" {(number - 1)}");
                number--;
            }
            return " ";
        }
    }
}
