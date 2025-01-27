using System;
class Program
{

private static char[] secretWord = "hangman".ToCharArray();
private static char[] guessWord = "_______".ToCharArray();

    static void Main(string[] args)
    {
        int attempts = 6;
        int ret = 1;
        bool wordGeussd = false;
        while (!wordGeussd && attempts > 0)
        {
            Console.WriteLine("\nCurrent word: " + new string(guessWord));
            Console.WriteLine("\nattempts: " + attempts);
            if (!Game())
            {
                attempts--;
            }
            if (new string(guessWord) == new string(secretWord)) // (guessWord == secretWord)
            {
                wordGeussd = true;
                break;
            }
        }
        wordGeussd = (new string(guessWord) == new string(secretWord));
        if (wordGeussd == true)
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

    static bool Game()
    {
        bool found = false;
        Console.Write("\nEnter a single letter : ");
        string input = Console.ReadLine();

        if (input.Length != 1)
        {
            SetConsoleColor(ConsoleColor.Red);
            Console.WriteLine("\nYou must enter only one letter!");
            ResetConsoleColor();
            return (false);
        }

        char guess = input[0];
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == input[0])
            {
                found = true;
                if (guessWord[i] == '_')
                {
                    guessWord[i] = input[0];
                }
            }
        }
        if (found)
        {
            SetConsoleColor(ConsoleColor.Green);
            Console.WriteLine("\nCorrect!");
            ResetConsoleColor();
        }
        else
        {
            SetConsoleColor(ConsoleColor.Red);
            Console.WriteLine("\nTry again!");
            ResetConsoleColor();
        }
        return (found);
    }

    static void SetConsoleColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    static void ResetConsoleColor()
    {
        Console.ResetColor();
    }
}