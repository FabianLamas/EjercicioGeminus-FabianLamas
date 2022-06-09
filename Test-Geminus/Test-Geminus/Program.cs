using System;

namespace Test_Geminus
{
    internal class Program
    {
        private static int bottom = 1;
        private static int top = 10;
        private static int defaultValue = 5;

        public static void Main(string[] args)
        {
            Console.WriteLine("Case 6");
            PrintBoard(6);
        }

        public static void PrintBoard(int inputN)
        {
            int squares = GetNumberOfSquares(inputN);
            String[,] board = new String[squares, squares];

            for (int i = 0; i < squares; i++)
            {
                for (int j = 0; j < squares; j++)
                {
                    board[i,j] = (i + j) % 2 == 0 ? "X" : "_";
                }
            }

            for (int i = 0; i < squares; i++)
            {
                for (int j = 0; j < squares; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static int GetNumberOfSquares(int numberOfSquares)
        {
            return TestRange(numberOfSquares, bottom, top) ? numberOfSquares : defaultValue;
        }

        private static bool TestRange(int numberToCheck, int bottom, int top)
        {
            return (numberToCheck >= bottom && numberToCheck <= top);
        }
    }
}
