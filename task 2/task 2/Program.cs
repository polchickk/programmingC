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
            int number1 = 21;
            int number2 = -3;

            Console.WriteLine($"Произведение: {number1} * {number2} = {Multiply(number1,number2)}");

           //Console.WriteLine($"Произведение: {number1} * {number2} = {Divide(number1, number2)}");

            Console.ReadKey();
        }
        static int Multiply(int number1,int number2)
        {
            int result = 0;
            for (int i = 0; i < number1; i++)
            
                result += number2;

            return result;
        }

        //static int Divide(int number1, int number2)
        //{
        //    int result = 0;
            
        //    for (int i = 0; i < number1; i--)
        //    {
        //        result += number2;
        //    }

        //    return result;
        //}
    }
}
