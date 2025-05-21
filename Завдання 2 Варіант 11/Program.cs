using System;
using System.Text;

namespace Variant11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть рядок символів");
            string input = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (char ch in input)
            {
                
                if ((ch >= 'A' && ch <= 'I') || (ch >= 'a' && ch <= 'i'))
                {
                    
                    int digit = (char.ToUpper(ch) - 'A') + 1;
                    sb.Append(digit);
                }
            }

            string result = sb.ToString();
            Console.WriteLine("Результат: " + result);

        }
        static void Switcik(string input)
        {
            var sb = new StringBuilder();

            foreach (char ch in input)
            {
                switch (char.ToLower(ch))
                {
                    case 'a': sb.Append('1'); break;
                    case 'b': sb.Append('2'); break;
                    case 'c': sb.Append('3'); break;
                    case 'd': sb.Append('4'); break;
                    case 'e': sb.Append('5'); break;
                    case 'f': sb.Append('6'); break;
                    case 'g': sb.Append('7'); break;
                    case 'h': sb.Append('8'); break;
                    case 'i': sb.Append('9'); break;
                }
            }

            string result = sb.ToString();
            Console.WriteLine("Результат: " + result);

            Console.WriteLine("Використаємо метод у якому масив кортежів для зберігання відповідей");

            Correct(input);
        }
        static void Correct(string input)
        {
            var sb = new StringBuilder();

            var mappings = new (char Letter, char Digit)[]
            {
                ('a', '1'),
                ('b', '2'),
                ('c', '3'),
                ('d', '4'),
                ('e', '5'),
                ('f', '6'),
                ('g', '7'),
                ('h', '8'),
                ('i', '9')
            };

            foreach (char ch in input)
            {
                char lowerCh = char.ToLower(ch);

                foreach (var mapping in mappings)
                {
                    if (mapping.Letter == lowerCh)
                    {
                        sb.Append(mapping.Digit);
                        break; 
                    }
                }
            }

            string result = sb.ToString();
            Console.WriteLine("Результат: " + result);
        }
    }
}
