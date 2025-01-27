using System;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("세로로 출력");
        for (int i = 1; i < 10; i++)
        {
            for(int j = 2; j < 10; j++)
            {
                Console.Write($"{j} x {i} = {i * j,2}     ");
            }
            
        Console.WriteLine();
        }

        Console.WriteLine("가로로 출력");
        for (int i = 2; i < 10; i++)
        {
            for(int j = 1; j < 10; j++)
            {
                Console.Write($"{i} x {j} = {i * j,2}     ");
            }
            
        Console.WriteLine();
        }
    }
}