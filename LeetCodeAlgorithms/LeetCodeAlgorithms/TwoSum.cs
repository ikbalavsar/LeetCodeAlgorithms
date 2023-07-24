using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class TwoSum
    {
        public int[] TwoSumm(int[] nums, int target)
        {

            var total = 0;
            bool isSuccess = false;
            int[] indexes = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                var firstNum = nums[i];

                for (int j = i + 1; j < nums.Length; j++)
                {
                    var secondNum = nums[j];


                    total = firstNum + secondNum;
                    if (total == target)
                    {
                        isSuccess = true;
                        indexes[0] = i;
                        indexes[1] = j;
                    }
                }

                if (isSuccess == true)
                {
                    break;
                }
            }

            return indexes;

        }
    }
}
