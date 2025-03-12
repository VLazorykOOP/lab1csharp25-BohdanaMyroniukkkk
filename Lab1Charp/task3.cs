using System;

class Program3
{
    static void Main3(string[] args)
    {
        Console.WriteLine("Введiть координату x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введiть координату y:");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x < 0 || y < 0)
        {
            Console.WriteLine("Нi (точка поза доцiльною областю, так як x або y вiд'ємнi)");
        }
        else if (x == 70 && y >= 0 && y <= 70) 
        {
            Console.WriteLine("На межi");
        }
        else if (y == x && y <= 70) 
        {
            Console.WriteLine("На межi");
        }
        else if (x <= 70 && y <= x && y >= 0) 
        {
            Console.WriteLine("Так");
        }
        else
        {
            Console.WriteLine("Нi");
        }
    }
}