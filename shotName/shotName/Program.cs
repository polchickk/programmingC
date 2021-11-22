using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shotName
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new[]
            {
            "Александр Сергеевич Пушкин",
                "Михаил Юрьевич Лермонтов",
                "Александр Блок"
            };
            foreach(var name in names)
                Console.WriteLine(ShortName(name));

            Console.ReadKey();
        }
        static string ShortName(string fullName)
        {
            
            var names = fullName.Split();
            //Debug.Assert(names.Length > 2);
            try
            {
                return $"{names[0][0]}. {names[1][0]}. {names[2]}";
            }
            catch
            {
                Console.Write($"\"{fullName}\"-строка должна содержать фио через пробел!");
                return "";
            }
        }
    }
}
