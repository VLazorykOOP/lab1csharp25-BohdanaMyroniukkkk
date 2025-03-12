using System;

class Program5
{
    static double SquareOfSum(double a, double b)
    {
        double sum = a + b;
        return sum * sum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введiть перше дiйсне число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введiть друге дiйсне число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        double result = SquareOfSum(number1, number2);
        Console.WriteLine($"Квадрат суми {number1} i {number2} дорiвнює {result}");
    }
}