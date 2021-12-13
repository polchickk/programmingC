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
        
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Возраст должен быть положительным числом"); 
            }
        }

        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }

        //public string GetFullName()
        //{
        //    return FullName;
        //}

        static void PrintSpesies()
        {
            Console.WriteLine(Person.Species);
        }
       public void PrintInfo()
        {
            Console.WriteLine($"{Species}: {FullName}, возраст: {Age}");
        }
    }
}
