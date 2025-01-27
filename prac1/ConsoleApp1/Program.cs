using System;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[100];
        int[] b = new int[100];

        int i = 0;
        Console.WriteLine("for을 사용한 홀수 출력 : ");
        for (; i < 100; i++)
        {
            a[i] = i + 1;
            if (i % 2 == 0)
            {
                Console.WriteLine(a[i]);
            }
        }

        i = 0;
        Console.WriteLine("while을 사용한 홀수 출력 : ");
        while (i < 100)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(a[i]);
            }
            i++;
        }

        Console.WriteLine("do-while을 사용한 홀수 출력 : ");
        i = 0;
        do
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(a[i]);
            }
            i++;
        } while (i < 100);
    }
}