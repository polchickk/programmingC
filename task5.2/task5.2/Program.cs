using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "чемпионат";
            string result = str.Substring(3, 1)
                + str.Substring(5, 2)
                + str.Substring(0, 1)
                + str.Substring(5, 1);
            string res = str.Substring(8, 1)
                + str.Substring(1, 3);
            Console.WriteLine(result);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
