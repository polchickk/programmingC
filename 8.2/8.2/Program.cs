using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество вводимых значений");
            var n = int.Parse(Console.ReadLine());

            var proiz = 1.0;

            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите положительное действительное число");
                var a = int.Parse(Console.ReadLine());
                
                var product = Math.Pow(a * proiz, 1.0 / i);
                proiz *= a;
                
                Console.WriteLine($"Среднее геометрическое: {product}");
            }

            Console.ReadKey();
        }
    }
}
