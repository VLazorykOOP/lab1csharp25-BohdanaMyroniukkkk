using System;

class Program4
{
    static void Main4(string[] args)
    {
        Console.WriteLine("Введiть кiлькiсть балiв (0-100):");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score < 0 || score > 100)
        {
            Console.WriteLine("Помилка: Введiть число вiд 0 до 100!");
        }
        else if (score >= 90 && score <= 100)
        {
            Console.WriteLine("вiдмiнно");
        }
        else if (score >= 70 && score <= 89)
        {
            Console.WriteLine("добре");
        }
        else if (score >= 50 && score <= 69)
        {
            Console.WriteLine("задовiльно");
        }
        else 
        {
            Console.WriteLine("незадовiльно");
        }
    }
}