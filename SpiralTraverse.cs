using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification
{
    public static class SpiralTraverse
    {
        public static List<int> DoSpiralTraverse(int[,] array)
        {
            int startRow = 0, endRow = array.GetLength(0) - 1, startCol = 0 , endCol = array.GetLength(1) - 1;
            var result = new List<int>();
            while (startRow <= endRow && startCol <= endCol)
            {
                for(int col = startCol; col <= endCol; col++)
                    result.Add(array[startCol, col]);

                for (int row = startRow + 1; row <= endRow; row++)
                    result .Add(array[row, endCol]);

                for (int col = endCol - 1; col >= startCol; col--)
                {
                    if (startRow == endRow)
                        break;

                    result.Add(array[endRow, col]);
                }

                for ( int row = endRow - 1; row > startRow; row--)
                {
                    if (startCol == endCol)
                        break;

                    result.Add(array[row, startCol]);
                }

                startRow++;
                endRow--;
                startCol++;
                endCol--;
            }
            return result;
        }
    }
}
