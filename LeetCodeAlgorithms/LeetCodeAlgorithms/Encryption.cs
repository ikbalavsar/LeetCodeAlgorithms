using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    public class Encryption
    {
        //        Input(stdin) haveaniceday
        //
        //        Expected Output hae and via ecy
        //
        public static string encryption(string s)
        {
            var strCount = s.Count();

            double squareRoot = Math.Sqrt(strCount);

            var upperLimit = (int)Math.Ceiling(squareRoot);
            var downLimit = (int)Math.Floor(squareRoot);

            if (upperLimit * downLimit < strCount)
            {
                downLimit++;
            }

            string[] newStrList = new string[downLimit];
            string resultString = "";
            var j = 0;

            for (int i = 0; i < strCount; i += upperLimit)
            {

                string part = s.Substring(i, Math.Min(upperLimit, s.Length - i));
                newStrList[j] = part;
                j++;

            }

            for (int i = 0; i < upperLimit; i++)
            {
                foreach (var item in newStrList)
                {
                    if (i >= item.Length)
                    {
                        continue;
                    }
                    else
                    {
                        resultString += item[i];

                    }
                }
                resultString += " ";
            }
            return resultString;



        }

    }
}
}
