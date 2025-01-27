using System;

class Program
{

    static void Main(string[] args)
    {
        double a = 0;
        double b = 0;
        bool valid = false;
        Console.WriteLine("This calculator outputs the values inputting A and B");

        while (valid == false)
        {
            string? input;
            Console.Write("enter A : ");
            input = Console.ReadLine();
            Console.Clear();
            valid = double.TryParse(input, out a);
            if (!valid)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
        valid = false;
        while (valid == false)
        {
            string? input;
            Console.Write("enter B : ");
            input = Console.ReadLine();
            Console.Clear();
            valid = double.TryParse(input, out b);
            if (!valid)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
        Console.WriteLine("result : " + (a + b));
    }
}