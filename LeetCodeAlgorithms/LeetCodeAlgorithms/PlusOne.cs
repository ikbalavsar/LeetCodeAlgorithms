using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class PlusOne
    {
        public static int[] PlusOnee(int[] digits)
        {

            int n = digits.Length;
            int carry = 1;

            for (int i = n - 1; i >= 0; i--)
            {
                int sum = digits[i] + carry;
                digits[i] = sum % 10;
                carry = sum / 10;
            }

            if (carry > 0)
            {
                int[] newArray = new int[n + 1];
                newArray[0] = carry;
                Array.Copy(digits, 0, newArray, 1, n);
                return newArray;
            }

            return digits;


        }
    }
}
