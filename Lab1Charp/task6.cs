using System;

class Program6
{
    static void Main6(string[] args)
    {
        Console.WriteLine("Введiть значення x:");
        double x;
        if (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Помилка: Невiрний формат числа x!");
            return;
        }

        if (x == 0)
        {
            Console.WriteLine("Помилка: x не може бути 0 (можливе дiлення на нуль у виразi)!");
            return;
        }

        Console.WriteLine("Введiть значення y:");
        double y;
        if (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Помилка: Невiрний формат числа y!");
            return;
        }

        double denominator = x * x + 2 * x + 5; 
        double numerator = y * y + 4; 
        double fraction = numerator / denominator; 
        double result = (fraction + 1) * x; 

        Console.WriteLine($"Значення виразу дорiвнює: {result}");
    }
}