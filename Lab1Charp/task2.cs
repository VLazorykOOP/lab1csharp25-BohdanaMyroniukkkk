using System;

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть тризначне число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 100 || number > 999)
        {
            Console.WriteLine("Помилка: введiть тризначне число (вiд 100 до 999)");
            return;
        }

        int firstDigit = number / 100;

        int lastDigit = number % 10;

        if (firstDigit > lastDigit)
        {
            Console.WriteLine($"Перша цифра ({firstDigit}) бiльша за останню ({lastDigit})");
        }
        else if (lastDigit > firstDigit)
        {
            Console.WriteLine($"Остання цифра ({lastDigit}) бiльша за першу ({firstDigit})");
        }
        else
        {
            Console.WriteLine($"Перша цифра ({firstDigit}) дорiвнює останнiй ({lastDigit})");
        }
    }
}