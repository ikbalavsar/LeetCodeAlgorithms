using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {

            string cleanedString = "";


            foreach (char c in s)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    cleanedString += Char.ToLower(c);
                }
            }



            char[] charArray = cleanedString.ToCharArray();
            char[] reversedArray = (char[])charArray.Clone();
            Array.Reverse(reversedArray);

            for (int i = 0; i < charArray.Length; i++)
            {

                if (charArray[i] != reversedArray[i])
                {
                    return false;
                }

            }

            return true;



        }
    }
}
