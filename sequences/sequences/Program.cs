using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Numerics;

namespace sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new Sequence();

            Console.WriteLine("Последовательность Фибоначчи");
            PrintSequence(sequence.Fibonacci());

            Console.WriteLine("\nФакториалы");
            PrintSequence(sequence.Factorial());

            Console.ReadKey();
        }

        static void PrintSequence(IEnumerable<BigInteger> s)
        {
            var i = 1;
            foreach(var elem in s)
            {

                Thread.Sleep(500); //выводит результат через 500мс
                Console.WriteLine($"{i++} = {elem}");

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Escape)
                        break;
                }
            }
        }
    }
}
