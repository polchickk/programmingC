using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите 2 натуральных числа ");
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Произведение: {number1} * {number2} = {Multiply(number1,number2)}");

          Console.WriteLine($"Частное: {number1} / {number2} = {Divide(number1, number2)}");
           Console.WriteLine( Remainder(number1, number2));

            Console.ReadKey();
        }
        static int Multiply(int number1,int number2)
        {
            int result = 0;
            for (int i = 0; i < number1; i++)
            
                result += number2;

            return result;
        }

        static int Divide(int number1, int number2)
        {
            int count = 0;

                while (number1 >= number2)
                {
                    number1 -= number2;
                    count += 1;
                }

            return count;
        }

        static int Remainder(int number1, int number2)
        {
            if (number1 < number2)
                return 0;
            int count = 0;
           
            while (number1 >= number2)
            {
                number1 -= number2;
                count += 1;
            }
            
            return number1;

        }
    }
}
