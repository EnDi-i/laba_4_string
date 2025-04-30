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
        }
    }
}
