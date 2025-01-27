using System;

class Program
{
    static void Main(string[] args)
    {
        decimal weight = 0;
        decimal height = 0;
        decimal bmi = 0;
        bool valid = false;

        Console.WriteLine("BMI calculator");
        while (valid == false)
        {
            string? input;
            Console.Write("Please enter your height : ");
            input = Console.ReadLine();
            Console.Clear();
            valid = (decimal.TryParse(input, out height) && height > 0);
            if (!valid)
            {
                Console.WriteLine("Please enter a valid number");
                continue ;
            }
            height = (height / 100);
        }
        valid = false;
        while (valid == false)
        {
            string? input;
            Console.Write("Please enter your weight : ");
            input = Console.ReadLine();
            Console.WriteLine("your weight : " + weight + "kg");
            Console.Clear();
            valid = (decimal.TryParse(input, out weight) && weight > 0);
            if (!valid)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
        bmi = (weight / (height * height));
        Console.WriteLine($"your BMI : {bmi:F1}");
    }
}