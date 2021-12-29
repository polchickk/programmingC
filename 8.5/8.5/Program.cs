using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника");
            var b = int.Parse(Console.ReadLine());

            int count = 0;
            while(a>0 && b > 0)
            {
                if (a > b)
                {
                    a = a - b;
                    Console.WriteLine($"сторона квадрата:{b}");
                }
                else if (b > a)
                {
                    b = b - a;
                    Console.WriteLine($"сторона квадрата:{a}");
                }
                else
                {
                    Console.WriteLine($"сторона квадрата:{a}");
                    break;
                }
                Console.WriteLine();
                count++;
                
            }
            Console.WriteLine();
            Console.WriteLine($"число квадратов: {count+1}");

            Console.ReadKey();

        }
    }
}
