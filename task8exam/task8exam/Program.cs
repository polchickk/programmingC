using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(IsCubeNumber(number));


            Console.ReadKey();
        }
        static bool IsCubeNumber(int number)
        {
            for (var i = 1; i <= number; i++)
            {
                if (number == i * i * i)
                    return true;
                
            }
            return false;
        }
    }
}
