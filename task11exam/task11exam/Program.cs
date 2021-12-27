using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите многозначный номер через пробел");
            var number = Console.ReadLine().Split();

            var numbers = new int[number.Length];
                for (var i = 0; i < numbers.Length; i++)
                     numbers[i] = int.Parse(number[i]);

            ControlNumber(numbers);

            Console.ReadKey();
        }

        static void ControlNumber(int[] number)
        {
            var x = 0;
            var sum = 0;
            if (number.Length % 2 == 0)
                for (var i = 0; i < number.Length; i += 2)
                {
                    if (2 * number[i] > 9)
                        x = 2 * number[i] - 9;
                    else
                        x = 2 * number[i];
                    sum = x + sum + number[i + 1];
                }
            else
                for (var i = 1; i < number.Length; i += 2)
                {
                    if (2 * number[i] > 9)
                        x = 2 * number[i] - 9;
                    else
                        x = 2 * number[i];
                    sum = x + sum + number[i - 1];
                }
            Console.WriteLine(sum);
            if(sum%10==0)
                Console.WriteLine($"Контрольная цифра: {number[number.Length-1]}");
            else
                Console.WriteLine($"Последовательность некорректна, в соответствии с алгоритмом Луна, контрольная цифра должна быть равна {10-(sum- number[number.Length - 1])%10} ");
        }
    }
}
