using System; 

class Program2 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Введіть тризначне число:"); 
        int number = Convert.ToInt32(Console.ReadLine()); 

        if (number < 100 || number > 999) 
        {
            Console.WriteLine("Помилка: введіть тризначне число (від 100 до 999)"); 
            return; 
        }

        int firstDigit = number / 100; 
        int lastDigit = number % 10; 

        if (firstDigit > lastDigit) 
        {
            Console.WriteLine($"Перша цифра ({firstDigit}) більша за останню ({lastDigit})"); 
        }
        else if (lastDigit > firstDigit) 
        {
            Console.WriteLine($"Остання цифра ({lastDigit}) більша за першу ({firstDigit})"); 
        }
        else 
        {
            Console.WriteLine($"Перша цифра ({firstDigit}) дорівнює останній ({lastDigit})"); 
        }
    } 
} 