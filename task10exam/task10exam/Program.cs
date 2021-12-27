using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число ");
            var number = int.Parse(Console.ReadLine());

            int count = 0;
            
            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                    count++;
                    
                }
               
                else
                {
                    number = 3 * number + 1;
                    count++;
                }

            }

            Console.WriteLine(count);
           
            Console.ReadKey();

        }
        static int GetMaxElement(int[] array)
        {
            var max = int.MinValue;

            foreach (var elem in array)
                if (elem > max)
                    max = elem;

            return max;
        }
    }
}
