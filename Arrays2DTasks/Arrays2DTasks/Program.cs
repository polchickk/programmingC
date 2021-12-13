using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2DTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[,] { { 3, -11, 8 }, { 0, 17, 5 } };
            PrintTable(numbers);

            var answer = IsContainsZero(numbers) ? "таблица содержит 0" : "таблица не содержит 0";
            Console.WriteLine($"{answer}\n");

            PrintTable(Transpose(numbers));

            Console.ReadKey();
        }
        static bool IsContainsZero(int[,] table)
        {
            foreach (var elem in table)
                if (elem == 0)
                    return true;
          
            return false;
        }
        static void PrintTable(int[,] table)
        {
            for (var row = 0; row < table.GetLength(0); row++)
            {
                for (var column = 0; column < table.GetLength(1); column++)
                    Console.Write($"{table[row, column],3} ");

                Console.WriteLine();
            }

            Console.WriteLine();
        }
        static int[,] Transpose(int[,] array)
        {
            var result = new int[array.GetLength(1), array.GetLength(0)];

            for (var i = 0; i < result.GetLength(0); i++)
                for (var j = 0; j < result.GetLength(1); j ++)
                    result[i, j] = array[j, i];

                    return result;
        }
    }
}
