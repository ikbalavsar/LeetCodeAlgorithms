using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Length == 1)
                {
                    if (target > nums[0])
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                if (i == nums.Length - 1)
                {
                    return nums.Length;
                }
                else
                {
                    var firstValue = nums[i];
                    var secondValue = nums[i + 1];
                    if (target > firstValue && target <= secondValue)
                    {
                        return i + 1;
                    }
                    else if (target <= firstValue)
                    {
                        return i;
                    }


                }



            }

            return nums.Length + 1;

        }
    }
}
