using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class MoveZeroes
    {
        public void MoveZeroess(int[] nums)
        {
            int nonZeroIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex] = nums[i];
                    nonZeroIndex++;
                }
            }


            while (nonZeroIndex < nums.Length)
            {
                nums[nonZeroIndex] = 0;
                nonZeroIndex++;
            }

        }
    }
}
