using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = Input("m");
            var n = Input("n");
           
            Console.WriteLine(IsMultiplyAndSum(m, n));
            
            Console.ReadKey();
        }
        
        static int Input(string name)
        {
            Console.WriteLine($"Введите целое число {name}");
            return int.Parse(Console.ReadLine());
        }
       
        static bool multiply(int m, int n)
        {
            return (m * n) % 5 == 0;
        }
        
        static bool sum(int m, int n)
        {
            return (m + n) % 5 != 0;
        }
       
        static bool IsMultiplyAndSum(int m, int n)
        {
            var a = multiply(m, n);
            var b = sum(m, n);
            
            return a && b;

         }
    }
}
