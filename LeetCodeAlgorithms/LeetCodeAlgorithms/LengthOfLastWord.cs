using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class LengthOfLastWord
    {
        public static int LengthOfLastWordd(string s)
        {
            string[] words = s.Split(" ");
            words = words.Where(str => !string.IsNullOrEmpty(str)).ToArray();


            int length = words.Length;

            var lengthOfLastWord = words[length - 1].Length;

            return lengthOfLastWord;

        }
    }
}
