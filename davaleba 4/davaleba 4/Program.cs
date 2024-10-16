using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_4
{
    class Program
    {

        static char[,] gameBoard = new char[3, 3];
        static char currentPlayer = 'X';
        static bool isGameOver = false;
        static int movesCount = 0;

        static void Main(string[] args)
        {
            InitializeBoard();
            while (!isGameOver)
            {
                Console.Clear();
                DrawBoard();
                PlayerMove();
                CheckForWin();
                SwitchPlayer();
            }
        }

        static void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = ' ';
                }
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine(" ---------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + "|");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i, j] + "|");
                }
                Console.WriteLine();
                Console.WriteLine(" ---------");
            }
        }

        static void PlayerMove()
        {
            int row, col;
            while (true)
            {
                Console.WriteLine($"Player {currentPlayer}, enter your move (row and column): ");
                if (int.TryParse(Console.ReadLine(), out row) && int.TryParse(Console.ReadLine(), out col) &&
                    row >= 0 && row < 3 && col >= 0 && col < 3 && gameBoard[row, col] == ' ')
                {
                    gameBoard[row, col] = currentPlayer;
                    movesCount++;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }
        }

        static void CheckForWin()
        {
            // Check rows, columns and diagonals for a win
            for (int i = 0; i < 3; i++)
            {
                if ((gameBoard[i, 0] == currentPlayer && gameBoard[i, 1] == currentPlayer && gameBoard[i, 2] == currentPlayer) ||
                    (gameBoard[0, i] == currentPlayer && gameBoard[1, i] == currentPlayer && gameBoard[2, i] == currentPlayer))
                {
                    isGameOver = true;
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    return;
                }
            }

            // Check diagonals
            if ((gameBoard[0, 0] == currentPlayer && gameBoard[1, 1] == currentPlayer && gameBoard[2, 2] == currentPlayer) ||
                (gameBoard[0, 2] == currentPlayer && gameBoard[1, 1] == currentPlayer && gameBoard[2, 0] == currentPlayer))
            {
                isGameOver = true;
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Player {currentPlayer} wins!");
                return;
            }

            // Check for a draw
            if (movesCount == 9)
            {
                isGameOver = true;
                Console.Clear();
                DrawBoard();
                Console.WriteLine("It's a draw!");
            }
        }

        static void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            Console.ReadLine();

        }
    }
}