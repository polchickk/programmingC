using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variant1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите натуральное число");
            var number = int.Parse(Console.ReadLine());

            int i = 2;
            Console.Write($"{number} = ");

            while (i <= number)
            {
                if (number % i == 0 && IsPrime(i))
                {
                    Console.Write(i);
                    number /= i;
                    if (number > 1)
                        Console.Write("*");
                }
                else
                    i++;
            }

            Console.ReadKey();
        }

        static bool IsPrime(int number)
        {
            var d = 2;
            
            while (d < Math.Sqrt(number))
            {
                if (number % d == 0)
                    return false;

                d++;
            }
           
            return true;
        }
    }
}