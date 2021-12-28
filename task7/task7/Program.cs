using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Введите N-ю по лексикографическому порядку перестановку букв");
            int number = int.Parse(Console.ReadLine());

            char[] array = new char[] {'A','B','C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M' };
            BubbleSort(array);

            PrintIntArray(array);

            Console.ReadKey();
        }

        static int Factorial(int number)
        {
            var factorial = 1;
            
            for (var i = 1; i <= number; i++)
                factorial *=i;

            return factorial;  
        }
        static void PrintIntArray(char[] array)
        {
            foreach (var elem in array)
                Console.Write($"{elem} ");
            Console.WriteLine();
        }

        static void BubbleSort(char[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
                for (var j = 0; j < array.Length - 1 - i; j++)
                    if (array[j] > array[j + 1])
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
        }
    }
}
