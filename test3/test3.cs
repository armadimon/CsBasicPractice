using System;

class Program
{

    static void Main(string[] args)
    {
        int number = 0;
        string input = null;

        Console.Write("please input number : ");
        input = Console.ReadLine();

        if (int.TryParse(input, out int result))
        {
            number = result;
            Console.Write("Enter a number:" + input + "\n");

        int facto = 1;
        while (number > 0)
        {
            facto = facto * number;
            number--;
        }
        Console.Write("Factorial of " + input + " is " + facto);
        }
        else
        {
            Console.Write("No numbers entered");
        }

    }
}