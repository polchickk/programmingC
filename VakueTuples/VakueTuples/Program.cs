using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            (x, y) = (2, 7);
            PrintXY(x, y);

            (x, y) = (y, x);
            PrintXY(x, y);

            Console.ReadKey();
          
        }
        static void PrintXY(int x, int y)
        {
            Console.Write($"x={x}; y={y}");
        }
    }
}
