using System;
using System.Diagnostics;
using System.Text;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число n: ");
            int n = int.Parse(Console.ReadLine());
            string result;
            int choice;
            do
            {
                Console.WriteLine("Який метод будете використовувати: ");
                Console.WriteLine("1 - з використанням лише типу string, та додаванням чисел 1, 2, 3, ..., n у кінець за допомогою оператора += типу string");
                Console.WriteLine("2 - з використанням лише типу string, та додаванням чисел n, n–1, ..., 3, 2, 1 (саме в цьому порядку) в початок за допомогою оператора + типу string");
                Console.WriteLine("3 - з використанням як string, так і StringBuilder, та додаванням чисел 1, 2, 3, ..., n у кінець за допомогою метода Append типу StringBuilder");
                Console.WriteLine("4 - з використанням як string, так і StringBuilder, та додаванням чисел n, n–1, ..., 3, 2, 1 (саме в цьому порядку) в початок за допомогою метода Insert типу StringBuilder");
                Console.WriteLine("5 - змінити 'n'.");
                Console.WriteLine("0 - вихід");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Stopwatch sw = Stopwatch.StartNew();
                        result = String1(n);
                        //sw.Stop();
                        //Console.WriteLine($"Час виконання: {sw.ElapsedMilliseconds} мс");
                        Console.WriteLine(result);
                        break;
                    case 2:
                        //Stopwatch swу = Stopwatch.StartNew();
                        result = String2(n);
                        //swу.Stop();
                        //Console.WriteLine($"Час виконання: {swу.ElapsedMilliseconds} мс");
                        Console.WriteLine(result);
                        break;
                    case 3:
                        //Stopwatch swe = Stopwatch.StartNew();
                        result = StringBuilder3(n);
                        //swe.Stop();
                        //Console.WriteLine($"Час виконання: {swe.ElapsedMilliseconds} мс");
                        Console.WriteLine(result);
                        break;
                    case 4:
                        //Stopwatch swq = Stopwatch.StartNew();
                        result = StringBuilder4(n);
                        //swq.Stop();
                        //Console.WriteLine($"Час виконання: {swq.ElapsedMilliseconds} мс");
                        Console.WriteLine(result);
                        break;
                    case 5:
                        Console.WriteLine("Введіть нове число n: ");
                        n = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Виберіть один з варіантів"); 
                        break;
                }
            } while (choice != 0);

        }
        static string String1(int n)
        {
            string result = "";
            for(int i = 1; i <= n; i++)
            {
                result += i + (i == n ? "" : " ");
            }
            return result;
        }
        static string String2(int n)
        {
            string result = "";
            for (int i = n; i >= 1; i--)
            {
                result = i + (i == n ? "" : " ") + result;
            }
            return result;
        }
        static string StringBuilder3(int n)
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                sb.Append(i);
                if (i != n) sb.Append(" ");
            }
            string result = sb.ToString();
            return result;
        }
        static string StringBuilder4(int n)
        {
            var sb = new StringBuilder();
            for (int i = n; i >= 1; i--)
            {
                sb.Insert(0, i + (i == n ? "" : " "));
            }
            string result = sb.ToString();
            return result;
        }
    }
}