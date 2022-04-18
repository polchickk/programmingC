using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tree
{
    class Program
    {
        static Dictionary<string, string> tree = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Initialize();
        }
        static void Initialize()
        {
            string fileName;

            while (true)
            {
                Console.WriteLine("Введите имя файла");

                fileName = Console.ReadLine();

                if (fileName == string.Empty) return;

                if (File.Exists(fileName))
                    break;
                else
                    Console.WriteLine("Такого файла нет.\n");
            }

            using (var file=new StreamReader(fileName, Encoding.Default))
            {
                while (!file.EndOfStream)
                {
                    string[] record = file.ReadLine().Split('-');
                    tree[record[1].Trim()] = record[0].Trim();
                }
            }
        }


    }
}
