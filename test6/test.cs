using System;
class Program
{

    static void Main(string[] args)
    {
        Random rnd = new Random();
        int correctNumber = rnd.Next(1, 101);
        bool ret= true;
        while (ret)
        {
            ret = prog1(correctNumber);
        }
    }

    private static bool prog1(int correctNumber)
    {

        int guessNumber;
        string input = null;
        Console.Write("Enter your guess (1-100): ");
        input = Console.ReadLine();
        if (int.TryParse(input, out int result))
        {
            guessNumber = result;
            if (guessNumber > correctNumber)
            {

                Console.WriteLine("Too high! Try again.");
            }
            else if (guessNumber < correctNumber)
            {

                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number.");
                return(false);
            }
        }
        else
        {
            Console.WriteLine("No numbers entered");
        }
        return (true);
    }
}