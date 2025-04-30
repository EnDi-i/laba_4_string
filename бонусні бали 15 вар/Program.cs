using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        int balance = 0;
        bool isValid = true;

        foreach (char ch in input)
        {
            if (ch == '(')
            {
                balance++;
            }
            else if (ch == ')')
            {
                balance--;
                if (balance < 0)
                {
                    isValid = false;
                    break; 
                }
            }
        }

        if (balance != 0)
            isValid = false;

        Console.WriteLine(isValid ? "Правильна розстановка дужок" : "Неправильна розстановка дужок");
    }
}
