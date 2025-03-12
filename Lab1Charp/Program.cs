using System;

class Program
{
    static void Main3(string[] args)
    {
        Console.WriteLine("Введiть довжину кола:");
        double n = Convert.ToDouble(Console.ReadLine());

        // Формула: L = 2 * π * r, де L - довжина кола, r - радіус
        // Отже, r = L / (2 * π)
        double radius = n / (2 * Math.PI);

        Console.WriteLine($"Радіус кола дорівнює: {radius:F2}");
    }
}