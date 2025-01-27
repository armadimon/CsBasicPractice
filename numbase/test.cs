using System;
using System.Linq;
class Program
{
    
    static int strikes = 0;
    static int balls = 0;
    static string? userGuess = "";
    static void Main(string[] args)
    {    
        int attempts = 0;
        bool guessedCorrectly = false;
        string targetNumberString;
        int targetNumber;
        int[] digits = Enumerable.Range(0, 10).ToArray();    

        KnuthShuffle(digits);
        targetNumber = digits[0] * 100 + digits[1] * 10 + digits[2];
        targetNumberString = targetNumber.ToString();

        if (targetNumber < 100)
        {
            targetNumberString = string.Concat("0", targetNumberString);
        }

        while (!guessedCorrectly)
        {
            Console.WriteLine("\nattempts: " + attempts);
            if (!Game(targetNumberString))
            {
                attempts++;
            }
            if (targetNumberString == new string(userGuess))
            {
                guessedCorrectly = true;
                break;
            }
        }
        if (guessedCorrectly == true)
        {
            SetConsoleColor(ConsoleColor.Yellow);
            Console.WriteLine("\nCongratulation!! you guessed all word!");
            ResetConsoleColor();
        }
        else
        {
            Console.WriteLine("\nfailed");
        }
    }

    static bool Game(string targetNumberString)
    {
        Console.Write("\nGuess Number! (ex : 012): ");
        userGuess = Console.ReadLine();

        strikes = 0;
        balls = 0;
        if (userGuess == null || userGuess.Length > 4 || userGuess.Length < 1)
        {
            SetConsoleColor(ConsoleColor.Red);
            Console.WriteLine("\nYou must enter Number! (012 ~ 987)");
            userGuess = "";
            ResetConsoleColor();
            return (false);
        }

        for (int i = 0; i < targetNumberString.Length; i++)
        {
            for (int j = 0; j < targetNumberString.Length; j++)
            {
                if ( userGuess[i] == targetNumberString[j])
                {
                    if (i == j)
                    {
                        strikes++;
                    }
                    else
                    {
                        balls++;
                    }
                }
            }
        }

        SetConsoleColor(ConsoleColor.Green);
        Console.WriteLine("\nStrikes = " + strikes);
        ResetConsoleColor();
        SetConsoleColor(ConsoleColor.Yellow);
        Console.WriteLine("\nballs = " + balls);
        ResetConsoleColor();
        return (true);
    }

    static void SetConsoleColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    static void ResetConsoleColor()
    {
        Console.ResetColor();
    }

    static void KnuthShuffle(int[] arr)
    {
        Random rnd = new Random();
        
        for (int i = arr.Length - 1; i > 0; i--)
        {
            int j = rnd.Next(0, i + 1);
            
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}