﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;
            var p = 0;
            for (var i = 2; i <= 1000; i++)
            {
                number = i;
                if (number % 2 != 0)
                {
                    for (var m = 1; m < number; m++)
                    {
                        if (TheSieveOfEratosthenes(p) && (number == p + 2 * m * m))
                            break;
                        else
                            Console.WriteLine(number);
                    }
                }
            }
        }
       
        static bool TheSieveOfEratosthenes(int number)
        {
            
            for (var i = 2; i*i <= number; i++)
              

        }
    }
}
