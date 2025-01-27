using System;
class Program
{
    
    static int strikes = 0;
    static int balls = 0;
    static string userGuess = null;
    static int[] guessdTypefield = { 0, 0, 0}; // 0은 확인안함, 1은 ball, 2는 스트라이크
    static void Main(string[] args)
    {
        Random rnd = new();
        int targetNumber = rnd.Next(0, 1000);
        // int targetNumber = 221;
        int attempts = 0;
        bool guessedCorrectly = false;

        string targetNumberString = targetNumber.ToString();
        Console.WriteLine("\ncomputer set num : " + targetNumberString);
        while (!guessedCorrectly)
        {
            Console.WriteLine("\nattempts: " + attempts);
            if (!Game(targetNumberString))
            {
                attempts++;
            }
            if (targetNumberString == new string(userGuess)) // (guessWord == secretWord)
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
        Console.Write("\nGuess Number! (ex : 001): ");
        userGuess = Console.ReadLine();

        strikes = 0;
        balls = 0;
        if (userGuess.Length > 4 || userGuess.Length < 1)
        {
            SetConsoleColor(ConsoleColor.Red);
            Console.WriteLine("\nYou must enter Number! (001 ~ 999)");
            userGuess = null;
            ResetConsoleColor();
            return (false);
        }
        for (int i = 0; i < targetNumberString.Length; i++)
        {
            for (int j = 0; j < targetNumberString.Length; j++)
            {
                if ( userGuess[i] == targetNumberString[j] && guessdTypefield[j] != 2)
                {
                    if (i == j)
                    {
                        guessdTypefield[j] = 2;
                    }
                    else 
                    {
                        guessdTypefield[j] = 1;
                    }
                }
            }
        }
        for (int i = 0; i < guessdTypefield.Length; i++)
        {
            
            Console.WriteLine("\nguessdTypefield = " + guessdTypefield[i]);
            if (guessdTypefield[i] == 2)
            {
                strikes++;
            }
            else if (guessdTypefield[i] == 1)
            {
                balls++;
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

    //  static void clearField()
    //  {
    //         for (int i = 0; i < guessdTypefield.Length; i++)
    //         {
    //             guessdTypefield[i] = 0;
    //         }
    //     }
    static void SetConsoleColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    static void ResetConsoleColor()
    {
        Console.ResetColor();
    }
}