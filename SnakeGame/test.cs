using System;
class Program
{

    static void Main(string[] args)
    {
        List<char[]> board = new List<char[]>();
        int[] iBoard = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        string boardLayoutV = "   |   |   \n";
        string boardLayoutH = "-----------\n";
        board.Add(boardLayoutV.ToCharArray());
        board.Add(boardLayoutH.ToCharArray());
        board.Add(boardLayoutV.ToCharArray());
        board.Add(boardLayoutH.ToCharArray());
        board.Add(boardLayoutV.ToCharArray());

        int ret= 0;
        char mark = 'O';
        int j = 0;

        while (ret < 1)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(board[i]);
                Console.WriteLine();
            }
            if (j % 2 == 0)
            {
                mark = 'O';
            }
            else
            {
                mark = 'X';
            }
            ret = TicTacTo(board, iBoard, mark);
            if (ret != -1)
                j++;
    
        }
        for (int i = 0; i < 5; i++)
        {
            Console.Write(board[i]);
            Console.WriteLine();
        }
        if (ret == 1)
        {
            Console.WriteLine("Player 1 - Win!!");
        }
        else if (ret == 2)
        {
            Console.WriteLine("Player 2 - Win!!");
        }
        else if (ret == 3)
        {
            Console.WriteLine("Draw!!");
        }
    }
    private static int TicTacTo( List<char[]> board, int[] iBoard, char mark)
    {

        string? input = null;
        int ret;
        
        if (mark == 'X')
            Console.WriteLine("Turn : Player 1");
        else
            Console.WriteLine("Turn : Player 2");
        Console.Write("Enter Number (1~9) : ");
        input = Console.ReadLine();
        Console.Clear();
        if (!int.TryParse(input, out int result) || (result < 1 || result > 9))
        {
            Console.WriteLine("Plz enter correct Number(1~9)!");
            return (-1);
        }
        result--;
        if (iBoard[result] < 1)
        {
            Console.WriteLine("You can't put there!");
            return (-1);
        }
        if (result / 3 == 0)
        {
            char[] temp = board[0];
            temp[1 + (result % 3) * 4] = mark;
            if (mark == 'X')
                iBoard[result] = -1;
            else if (mark == 'O')
                iBoard[result] = -2;
        }
        else if (result / 3 == 1)
        {
            char[] temp = board[2];
            temp[1 + (result % 3) * 4] = mark;
            if (mark == 'X')
                iBoard[result] = -1;
            else if (mark == 'O')
                iBoard[result] = -2;
        }
        else if (result / 3 == 2)
        {

            char[] temp = board[4];
            temp[1 + (result % 3) * 4] = mark;
            if (mark == 'X')
                iBoard[result] = -1;
            else if (mark == 'O')
                iBoard[result] = -2;
        }
        if ((ret = Check(iBoard)) != 0)
        {
            return(ret);
        }
        return (0);
    }

    private static int CheckChar(int checkNum)
    {
        int ret = 0;

        if (checkNum == -1)
        {
            ret = 1;
        }
        else if (checkNum == -2)
        {
            ret = 2;
        }
        return (ret);
    }
    private static int Check(int[] iBoard)
    {
        int ret = 0;

        if (iBoard[0] == iBoard[1] && iBoard[1] == iBoard[2])
        {
            ret = CheckChar(iBoard[0]);
        }
        else if (iBoard[3] == iBoard[4] && iBoard[4] == iBoard[5])
        {
            ret = CheckChar(iBoard[3]);
        }
        else if (iBoard[6] == iBoard[7] && iBoard[7] == iBoard[8])
        {
            ret = CheckChar(iBoard[6]);
        }
        else if (iBoard[0] == iBoard[3] && iBoard[3] == iBoard[6])
        {
            ret = CheckChar(iBoard[0]);
        }
        else if (iBoard[1] == iBoard[4] && iBoard[4] == iBoard[7])
        {
            ret = CheckChar(iBoard[1]);
        }
        else if (iBoard[2] == iBoard[5] && iBoard[5] == iBoard[8])
        {
            ret = CheckChar(iBoard[2]);
        }
        else if (iBoard[0] == iBoard[4] && iBoard[4] == iBoard[8])
        {
            ret = CheckChar(iBoard[0]);
        }
        else if (iBoard[2] == iBoard[4] && iBoard[4] == iBoard[6])
        {
            ret = CheckChar(iBoard[2]);
        }
        else if (iBoard[0] < 0 &&
            iBoard[1] < 0 &&
            iBoard[2] < 0 &&
            iBoard[3] < 0 &&
            iBoard[4] < 0 &&
            iBoard[5] < 0 &&
            iBoard[6] < 0 &&
            iBoard[7] < 0 &&
            iBoard[8] < 0 )
            ret = 3;
        else
            ret = 0;
        return (ret);
    }

}