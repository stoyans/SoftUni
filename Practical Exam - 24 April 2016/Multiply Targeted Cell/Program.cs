using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Targeted_Cell
{
    class Multiply_Targeted_Cell
    {
        static void Main()
        {
            string[] rowsCols = Console.ReadLine().Split(' ');
            int rows = int.Parse(rowsCols[0]);
            int cols = int.Parse(rowsCols[1]);
            long[,] digitMatrix = new long[rows, cols];
            long sumOfneighbours = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split(' ');

                for (int k = 0; k < cols; k++)
                {
                    digitMatrix[i, k] = int.Parse(line[k]);
                }
            }

            string[] target = Console.ReadLine().Split(' ');
            int targetRow = int.Parse(target[0]);
            int targetCol = int.Parse(target[1]);
            long targetValue = digitMatrix[targetRow, targetCol];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((row == targetRow - 1 && col == targetCol - 1)
                        || (row == targetRow - 1 && col == targetCol) || (row == targetRow - 1 && col == targetCol + 1)
                        || (row == targetRow && col == targetCol - 1) || (row == targetRow && col == targetCol + 1)
                        || (row == targetRow + 1 && col == targetCol - 1) || (row == targetRow + 1 && col == targetCol)
                        || row == targetRow + 1 && col == targetCol + 1)
                    {
                        sumOfneighbours += digitMatrix[row, col];
                    }

                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((row == targetRow - 1 && col == targetCol - 1)
                        || (row == targetRow - 1 && col == targetCol) || (row == targetRow - 1 && col == targetCol + 1)
                        || (row == targetRow && col == targetCol - 1) || (row == targetRow && col == targetCol + 1)
                        || (row == targetRow + 1 && col == targetCol - 1) || (row == targetRow + 1 && col == targetCol)
                        || row == targetRow + 1 && col == targetCol + 1)
                    {
                        digitMatrix[row, col] *= targetValue;
                    }
                    else if (row == targetRow && col == targetCol)
                    {
                        digitMatrix[row, col] = sumOfneighbours * digitMatrix[targetRow, targetCol];
                    }

                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (k > 0)
                    {
                        Console.Write(' ');
                    }
                    Console.Write(digitMatrix[i, k]);
                }
                Console.WriteLine();
            }
        }
    }
}
