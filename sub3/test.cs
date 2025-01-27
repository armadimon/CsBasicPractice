using System;

class Program
{

    static void Main(string[] args)
    {
        double celsius  = 0;
        double fahrenheit = 0;
        bool valid = false;

        while (valid == false)
        {
            string? input;
            Console.Write("Please enter Celsius temperature : ");
            input = Console.ReadLine();
            Console.Clear();
            valid = double.TryParse(input, out celsius);
            if (!valid)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
        fahrenheit = (celsius * 1.8) + 32;
        Console.WriteLine("you entered " + celsius + " °C");
        Console.WriteLine("you entered " + fahrenheit + " °F");
    }
}