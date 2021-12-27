using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском языке");
            var text = Console.ReadLine();

            var vowels = new[] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };

            int count = 0;

            for (int i = 0; i < text.Length; i++)

                for (int j = 0; j < vowels.Length; j++)

                    if (vowels[j] == text[i])
                        count++;

            CountEachVowel(text, 'а', 'А');
            CountEachVowel(text, 'е', 'Е');
            CountEachVowel(text, 'ё', 'Ё');
            CountEachVowel(text, 'и', 'И');
            CountEachVowel(text, 'о', 'О');
            CountEachVowel(text, 'у', 'У');
            CountEachVowel(text, 'э', 'Э');
            CountEachVowel(text, 'ю', 'Ю');
            CountEachVowel(text, 'я', 'Я');
            CountEachVowel(text, 'ы', 'Ы');

            Console.WriteLine($"Общее количество гласных: {count}");

            Console.ReadKey();
        }

        static void CountEachVowel(string text, char letter, char LETTER)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
                if (letter == text[i] || LETTER == text[i])
                    count++;

            Console.WriteLine($"количество гласной {letter}: {count} ");
        }
    }
}
