using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное четное число, большее 4");
            var number = int.Parse(Console.ReadLine());

            var flag = false;
            var number1 = 0;
            var number2 = 0;

            for (int i = 1; i < number / 2 + 1; i++)
                if (IsPrime(i) && IsPrime(number- i))
                {
                    flag = true;
                    number1 = i;
                    number2 = number - i;
                }

            if (flag)
                Console.WriteLine($"{number} = {number2} - {number1}");

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
