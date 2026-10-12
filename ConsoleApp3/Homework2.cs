using System.Runtime.CompilerServices;
namespace ConsoleApp3;

public class Homework2
{
    static void Main(string[] args)
    {
        char[,] board = new char[3, 3];
        char currentPlayer = 'X';
        bool gameOver = false;
        while (!gameOver)
        {
            PrintBoard(board);
            MakeMove(board, currentPlayer);
            if (CheckWin(board, currentPlayer))
            {
                PrintBoard(board);
                Console.WriteLine($"{currentPlayer} won:");
                gameOver = true;
            }else if (CheckDraw(board))
            {
                PrintBoard(board);
                Console.WriteLine("Draw;");
                gameOver = true;
            }
            else
            {
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
        }
    }

    static void PrintBoard(char[,] board)
    {
        for (int row = 0; row < 3; row++)
        {
            Console.WriteLine($"{board[row, 0]} | {board[row, 1]} | {board[row, 2]}");

            if (row < 2)
                Console.WriteLine("--+---+--");
        }
    }

    static void MakeMove(char[,] board, char currentPlayer)
    {
        while (true)
        {
            Console.WriteLine($"{currentPlayer} must choose a move");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("choose 1-9 number");
                continue;
            }

            if (choice < 1 || choice > 9)
            {
                Console.WriteLine("number must be between 1 and 9։");
                continue;
            }

            int row = (choice - 1) / 3;
            int column = (choice - 1) % 3;

            if (board[row, column] == 'X' || board[row, column] == 'O')
            {
                Console.WriteLine("This cell is already taken.");
                continue;
            }

            board[row, column] = currentPlayer;
            break;
        }
    }

    static bool CheckWin(char[,] board, char currentPlayer)
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer &&
                board[i, 1] == currentPlayer &&
                board[i, 2] == currentPlayer)
            {
                return true;
            }


            if (board[0, i] == currentPlayer &&
                board[1, i] == currentPlayer &&
                board[2, i] == currentPlayer)
            {
                return true;
            }
        }

        if (board[0, 0] == currentPlayer &&
            board[1, 1] == currentPlayer &&
            board[2, 2] == currentPlayer)
        {
            return true;
        }


        if (board[0, 2] == currentPlayer &&
            board[1, 1] == currentPlayer &&
            board[2, 0] == currentPlayer)
        {
            return true;
        }

        return false;
    }

    static bool CheckDraw(char[,] board)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                if (board[row, column] != 'X' &&
                    board[row, column] != 'O')
                {
                    return false;
                }
            }
        }

        return true;
    }
}


   