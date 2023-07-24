using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class IsSubsequence
    {
        public static bool IsSubsequenceWithoutOrder(string s, string t)
        {

            char[] sStringArray = s.ToCharArray();
            char[] tStringArray = t.ToCharArray();

            for (int i = 0; i < sStringArray.Length; i++)
            {
                char charValue = sStringArray[i];

                if (tStringArray.Contains(charValue))
                {
                    sStringArray = sStringArray.Where(c => c != charValue).ToArray();
                    tStringArray = tStringArray.Where(c => c != charValue).ToArray();

                    i--;
                }
                else
                {
                    return false;
                }
            }

            if (sStringArray.Length == 0)
            {
                return true;
            }
            return false;

        }

        public bool IsSubsequenceWithOrder(string s, string t)
        {
            int sIndex = 0;
            int tIndex = 0;

            while (sIndex < s.Length && tIndex < t.Length)
            {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }

                tIndex++;
            }


            return sIndex == s.Length;

        }
    }
}
