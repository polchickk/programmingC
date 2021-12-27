using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке, который необходимо зашифровать");
            var text = Console.ReadLine();
            text = text.ToUpperInvariant();

            Console.WriteLine("Введите ключ(сдвиг)");
            var key = int.Parse(Console.ReadLine());

            Console.WriteLine("Зашифрованное слово:" + Encoder(text,key));

            Console.WriteLine("Введите текст на русском языке, который необходимо дешифровать");
            var text2 = Console.ReadLine();
            text2 = text2.ToUpperInvariant();

            Console.WriteLine("Введите ключ(сдвиг)");
            var key2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Дешифрованное слово:" + Decoder(text2, key2));

            Console.ReadKey();
        }

        static string Encoder(string text,int key)
        {
            var result = "";

            var alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФЦЧШЩЪЫЬЭЮЯ";

            int count = alphabet.Length; //количество знаков в алфавите

            for (int i = 0; i < text.Length; i++)//цикл перебора букв шифруемого слова
            {
                for (int j = 0; j < alphabet.Length; j++)//цикл сравнения каждой бкувы с алфавитом
                {
                    if (text[i] == alphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                    {
                        int temp = j + key;//номер буквы+сдвиг в темп

                        while (temp >= count)//чтобы темп не уходил за рамки алфавита
                            temp -= count;

                        result = result + alphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                    }
                }

            }
            return result;
        }

        static string Decoder(string text, int key)
        {
            var result = "";

            var alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФЦЧШЩЪЫЬЭЮЯ";

            int count = alphabet.Length; //количество знаков в алфавите

            for (int i = 0; i < text.Length; i++)//цикл перебора букв шифруемого слова
            {
                for (int j = 0; j < alphabet.Length; j++)//цикл сравнения каждой бкувы с алфавитом
                {
                    if (text[i] == alphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                    {
                        int temp = j - key;//номер буквы+сдвиг в темп

                        while (temp >= count)//чтобы темп не уходил за рамки алфавита
                            temp -= count;

                        result = result + alphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                    }
                }

            }
            return result;
        }
    }
}
