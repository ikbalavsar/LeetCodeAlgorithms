using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class ContainsDuplicate
    {
        public bool ContainsDuplicatee(int[] nums)
        {

            Array.Sort(nums); // Sayıları sırala

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    return true; // Yan yana iki sayı aynı ise yinelenen sayı vardır
                }
            }

            return false; // Yinelenen sayı bulunamadı

        }
    }
}
