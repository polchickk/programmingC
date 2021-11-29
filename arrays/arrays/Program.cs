using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 5, -7, 11, 23, 56, 4 };
            PrintIntArray(array);
           
            Console.WriteLine();

            var clone = (int[])array.Clone();
            PrintIntArray(clone);
            Console.WriteLine();

            var copy = new int[array.Length];
            Array.Copy(array, copy, array.Length);
            PrintIntArray(copy);
            Console.WriteLine();

            Array.Sort(array);
            PrintIntArray(array);
            Console.WriteLine();

            Console.WriteLine(Array.BinarySearch(array,11));
            Console.WriteLine(Array.BinarySearch(array, 25));

            var matrix = new int[2,3] { {2, -1, 0}, {3, 5, -4} };

            Console.WriteLine($"Число строк:{matrix.GetLength(0)}");
             Console.WriteLine($"Число столбцов:{matrix.GetLength(1)}");
             Console.WriteLine($"Число измерений:{matrix.Rank}");
             Console.WriteLine($"Общее число элементов:{matrix.Length}");
           
            Console.ReadKey();
        }

        private static void PrintIntArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            
            Console.WriteLine();
        }
        static void PrintInt2DArray(int[,] table)
        {
            for(var i = 0; i < table.GetLength(0);i++) 
            { 
                for(var j=0;j<table.GetLength(1);j++)
                    Console.Write($"{table[i,j],3} ");
                Console.WriteLine();
            }
        }
    }
}
   
