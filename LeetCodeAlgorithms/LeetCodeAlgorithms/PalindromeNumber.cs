using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int number)
        {


            bool result = false;

            if (number < 0)
            {
                result = false;
            }
            else
            {
                int tmp_number = number;
                int reverse = 0;
                while (tmp_number != 0)
                {
                    reverse = (reverse * 10) + tmp_number % 10;
                    tmp_number /= 10;
                }
                Console.Write(reverse);
                if (number == reverse)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }



            return result;

        }
    }
}
