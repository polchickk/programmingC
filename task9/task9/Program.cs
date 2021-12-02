using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число действительных чисел массива");
            var input = int.Parse(Console.ReadLine());

            var numbers = new double[input];
            Random rand = new Random();
            for (var i = 0; i < input; i++)
                numbers[i] = rand.Next(0,input) + rand.NextDouble();
            
            PrintInArray(numbers);
            
            ReplaceSign(numbers);
            Console.Write("Массив с другим знаком у всех четных элементов массива: ");
            PrintInArray(numbers);
            
            Console.WriteLine($"квадратный корень суммы элементов массива: {GetSquareRootOfSum(numbers)}");
           
            var clone = (double[])numbers.Clone();
            GetSin(clone);
            Console.WriteLine($"Массив синусов произведения k(целого числа) и элементов: ");
            PrintInArray(clone);

            Console.ReadKey();
        }

        static void PrintInArray(double[] array)
        {
            foreach (var elem in array)
                Console.Write($"{elem, 0:F3} ");
            Console.WriteLine();
        }

        static void ReplaceSign(double[] array)
        {
             if (array.Length == 0)
                throw new ArgumentException("Массив не содержит ни одного элемента");

            for (var i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                    array[i] = (-1)*array[i];
        }

        static double GetSquareRootOfSum(double[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("Массив не содержит ни одного элемента");

            var sum = 0.0;
            
            foreach (var elem in array)
                sum += elem;
            
            var s = Math.Pow(Math.Abs(sum), 0.5);

            return s;
        } 
       
        static double[] GetSin(double[] array)
        {
             if (array.Length == 0)
                throw new ArgumentException("Массив не содержит ни одного элемента");

            Console.WriteLine("Введите целое число k:");
            var k=int.Parse(Console.ReadLine());

            var result=new double[array.Length];

             for (var i = 0; i < result.Length; i++)
                 result[i] = Math.Sin(array[i]*k);

             return result;
        }

    }
}
