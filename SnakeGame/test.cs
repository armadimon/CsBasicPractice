using System;
using System.Threading;
class Program
{
    public static void Main(string[] args)
    {
        int[,] board = new int[25, 50];
        Snake snake = new Snake();

        Console.Clear();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        snake.Dir = 1;
                        break;
                    case ConsoleKey.DownArrow:
                        snake.Dir = 2;
                        break;  
                    case ConsoleKey.LeftArrow:
                        snake.Dir = 3;
                        break;
                    case ConsoleKey.RightArrow:
                        snake.Dir = 4;
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
            ClearBoard(board);
            if (snake.IsFull == true)
            {
                snake.IsFull = false;
                GenApple(board);
            }
            if (snake.PostionUpdate(board) == 0)
            {
                Console.WriteLine("GAME OVER!!!");
                return ;
            }
            snake.SetPositionToBoard(board);
            Display(board);
            Thread.Sleep(100);
        }
    }
    private static void GenApple(int[,] board)
    {
        Random rnd = new Random();
        board[rnd.Next(1, 23), rnd.Next(1, 48)] = 3;
    }
    private static void ClearBoard(int[,] board)
    {

        for (int i = 0; i < 25; i++)
        {
            for (int j = 0; j < 50; j++)
            {
                if (board[i, j] != 3)
                {
                    if (i == 0 || i == 24)
                    {
                        board[i, j] = 1;
                    }
                    else
                    {
                        if (j == 0 || j == 49)
                        {
                            board[i, j] = 1;
                        }
                        else
                        {
                            board[i, j] = 0;
                        }
                    }
                }
            }
        }
    }
    private static void Display(int[,] board)
    {
        Console.SetCursorPosition(0, 0);
        for (int i = 0; i < 25; i++)
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
                else if (board[i, j] == 2)
                {
                    Console.Write('O');
                }
                else if (board[i, j] == 3)
                {
                    Console.Write('A');
                }
            }
            Console.WriteLine();
        }
    }

}

public class Position
{
    public int PosX { get; set; }
    public int PosY { get; set; }

    public Position (int x, int y)
    {
        PosX = x;
        PosY = y;
    }
}

public class Snake
{
    public bool IsFull { get; set; }

    // dir 1 = up, 2 = down, 3 = Left, 4 = right
    public int dir;

    private List<Position> position;
    public Snake ()
    {
        IsFull = true;
        position = new List<Position>();
        dir = 4;
        Position tempPos = new Position(20, 10);
        position.Add(tempPos);
    }

    public int Dir
    {
        get { return dir; }
        set { dir = value; }
    }


    private Position UpdateBodyPos(Position first, Position second)
    {
        Position prev = new Position(second.PosX, second.PosY);
        second.PosX = first.PosX;
        second.PosY = first.PosY;
        return (prev);
    }
    public int PostionUpdate(int[,] board)
    {
        Position prev = new Position(position[0].PosX, position[0].PosY);
        if (dir == 1)
        {
            position[0].PosY--;
        }
        else if (dir == 2)
        {

            position[0].PosY++;
        }
        else if (dir == 3)
        {
            position[0].PosX--;
        }
        else if (dir == 4)
        {
            position[0].PosX++;
        }

        for (int i = 1; i < position.Count; i++)
        {
            prev = UpdateBodyPos(prev, position[i]);
            if ((position[i].PosX == position[0].PosX) && (position[i].PosY == position[0].PosY))
                return (0);
        }
        if (board[position[0].PosY, position[0].PosX] == 3)
        {
            this.IsFull = true;
            position.Add(prev);
        }
        if (position[0].PosX >= 49 || position[0].PosX <= 0 ||
            position[0].PosY >= 24 || position[0].PosY <= 0 )
        {
            return (0);
        }
        return (1);
    }

    public void SetPositionToBoard(int[,] board)
    {
        for (int i = 0; i < position.Count; i++)
        {
            board[position[i].PosY, position[i].PosX] = 2;
        }
    }
}