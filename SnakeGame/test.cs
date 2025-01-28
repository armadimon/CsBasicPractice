using System;
using System.Threading;
class Program
{

    static void Main(string[] args)
    {
        int[,] board = new int[30, 50];

        CreateBoard(board);
        while (true)
        {
            Console.Clear();
            Display(board);
            Thread.Sleep(1000);
        }
    }

    private static void CreateBoard(int[,] board)
    {

        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                if (i == 0 || i == 29)
                {
                    board[i , j] = 1;
                }
                else
                {
                    if (j == 0 || j == 49)
                    {
                        board[i , j] = 1;
                    }
                    else
                    {
                        board[i , j] = 0;
                    }
                }

            }
        }
    }
    private static void Display(int[,] board)
    {
        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                if (board[i , j] == 1)
                {
                    Console.Write('#');
                }
                else if (board[i , j] == 0)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }

    private static int SnakeGame( int[] board, char mark)
    {
        while (true)
        {

        }
    }

}

class Snake
{
    
}