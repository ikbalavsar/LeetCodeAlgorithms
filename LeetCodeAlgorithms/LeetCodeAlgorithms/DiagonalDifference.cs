using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    public class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var firstDiagon = 0;
            var secondDiagon = 0;
            var result = 0;

            for (int i = 0; i < arr[0].Count(); i++)
            {
                for (int j = 0; j < arr[0].Count(); j++)
                {
                    if (i == j)
                    {
                        firstDiagon += arr[i][j];
                    }
                }
            }

            for (int i = 0; i < arr[0].Count(); i++)
            {
                for (int j = 0; j < arr[0].Count(); j++)
                {
                    if (i + j == arr[0].Count() - 1)
                    {
                        secondDiagon += arr[i][j];
                    }
                }
            }

            result = Math.Abs(firstDiagon - secondDiagon);
            return result;

        }
    }
}
