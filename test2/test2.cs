using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("숫자를 입력하세요 (구분자는 space 입니다) : ");
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');

        List<int> numbers = new List<int>();
        
        foreach (var item in inputs)
        {
            if (int.TryParse(item, out int num))
            {
                numbers.Add(num);
            }
        }
        if (numbers.Count > 0)
        {
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("sum : " + sum);


            double average = (double)sum / numbers.Count;
            Console.WriteLine("average : " + average); 
        }
        else
        {
            Console.WriteLine("입력된 숫자가 없습니다.");
        }
    }
}