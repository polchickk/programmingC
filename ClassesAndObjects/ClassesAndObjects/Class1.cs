using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
   public class Person
    {
        public static string Species = "Homo Sapience";
       
        public string Name;
        public string Surname;
        public int Age;

        static void PrintSpesies()
        {
            Console.WriteLine(Person.Species);
        }
    }
}
