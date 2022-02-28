using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorAlgebra;


namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(-2, 4, 0);

            Console.WriteLine(a+b);
            Console.ReadKey();
        }
    }
}
