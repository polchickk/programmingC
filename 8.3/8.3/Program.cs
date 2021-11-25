using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0, a = 1, sum = 0;

            while (a != 0)
            {
                Console.WriteLine("Введите целое число");
                a = int.Parse(Console.ReadLine());
                
                count++;
                sum += a;
            }
            Console.WriteLine($"Количество чисел последовательности:{count-1} " +
                $"сумма чисел последовательности: {sum}");

            Console.ReadKey();
        }
    }
}
