using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!File.Exists("text.txt"))
            File.Create("text.txt").Close();
            
            File.Copy("text.txt","copy.txt",true);
           // File.Delete("text.txt");

            var file = new FileInfo("copy.txt");
            Console.WriteLine(file.FullName);

            File.WriteAllText("text.txt","Привет, мир!");
            File.AppendAllText("text.txt", "\nHello,world!");

            var lines = new[] { "\nКак прекрасен этот мир - посмотри!", "Как прекрасен этот мир" };
            File.AppendAllLines("text.txt", lines);

            var text = File.ReadAllText("text.txt");
            Console.WriteLine(text);
            //Console.Write("===== конец первой печати ====");

            var textLines = File.ReadAllLines("text.txt");
            PrintLines(textLines);

            Console.WriteLine();

            //if (!File.Exists("stream.txt"))
            //    File.Create("stream.txt").Close();

            using(var stream = new StreamWriter("stream.txt", true)) // true текст остается, false старый текст удаляется
            {
                Console.WriteLine("Введите текст построчно. Enter в начале строке - конец ввода");
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input == string.Empty)
                        break;

                    stream.WriteLine(input);
                }
            }

            Console.WriteLine();

            using(var stream = new StreamReader("stream.txt"))
            {
                Console.WriteLine("=======");

                while(!stream.EndOfStream) //true бесконечный цикл 
                {
                    Console.WriteLine(stream.ReadLine());
                }
                Console.WriteLine("=======");
            }

            var dirName = Directory.GetCurrentDirectory();
            var listOfFiles = Directory.GetFiles(dirName);
            PrintLines(listOfFiles);

            Console.WriteLine();

            var currentDirectory = new DirectoryInfo(".");
            Console.WriteLine(currentDirectory.Name);

            var files = currentDirectory.GetFiles();
            PrintFiles(files);

            var dirs = currentDirectory.GetDirectories();
            PrintDirectoryNames(dirs);

            Console.ReadKey();
        }
        static void PrintLines(string[] lines)
        {
            foreach(var line in lines)
                Console.WriteLine(line);
        }

        static void PrintFiles(FileInfo[] files)
        {
            foreach (var file in files)
                Console.WriteLine(file.Name);
        }
        static void PrintDirectoryNames(DirectoryInfo[] directories)
        {
            foreach (var directory in directories)
                Console.WriteLine(directory);
        }
    }
}
