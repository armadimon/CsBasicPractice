using System;
class Program
{

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int max = numbers[0];
        int min = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
    }
}