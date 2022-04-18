using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //var champions =new Dictionary<string, int>();
            var champions = new SortedDictionary<string, int>();

            using (var file = new StreamReader("football.txt", Encoding.Default))
            {
                while (!file.EndOfStream)
                {
                    var key = file.ReadLine().Split('\t')[1];

                    if (champions.ContainsKey(key))
                        champions[key]++;
                    else
                        champions[key] = 1;
                }
            }

            foreach(var team in champions.Keys)
                Console.WriteLine($"{team} - {champions[team]}");

            Console.ReadKey();
        }
    }
}
