using System;
using System.Collections.Generic;
using System.Linq;

namespace GeminusEx_Two
{
    internal class Program
    {
        private static int areaLength = 4;
        private static int[] myArray = new int[] { 1, 2, -1, 1, 0, 1, 2, -1, -1, -2 };

        public static void Main(string[] args)
        {
            List<int> horizontal = new List<int>();
            List<int> vertical = new List<int>();

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    horizontal.Add(myArray[i]);
                }

                if (i % 2 != 0)
                {
                    vertical.Add(myArray[i]);
                }
            }

            int finalX = CalculateMoves(horizontal);
            int finalY = CalculateMoves(vertical);

            PrintArea(finalX, finalY);
            
        }

        public static void PrintArea(int x, int y)
        {
            string[,] matriz = new string[areaLength, areaLength];

            for (int i = 0; i < areaLength; i++)
            {
                for (int j = 0; j < areaLength; j++)
                {
                    matriz[i, j] = "O";
                }
            }

            matriz[y,x] = "X";

            for (int i = 0; i < areaLength; i++)
            {
                for (int j = 0; j < areaLength; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static int CalculateMoves(List<int> values)
        {
            int position = 0;

            for (int i = 0; i < values.Count; i++)
            {
                if (position + values[i] >= 0 && position + values[i] <= 3)
                {
                    position += values[i];
                }
            }

            return position;
        }
    }
}
