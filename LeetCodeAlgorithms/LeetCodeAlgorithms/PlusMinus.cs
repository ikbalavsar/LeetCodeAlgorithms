using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
     class PlusMinus
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {

            var positiveCount = 0;
            var negativeCount = 0;
            var zeroCount = 0;

            foreach (int item in arr)
            {
                if (item > 0)
                {
                    positiveCount++;
                }
                else if (item < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }

            List<double> newArr = new List<double>();

            double positiveRatio = (double)positiveCount / arr.Count();
            double negativeRatio = (double)negativeCount / arr.Count();
            double zeroRatio = (double)zeroCount / arr.Count();


            Console.WriteLine(positiveRatio);
            Console.WriteLine(negativeRatio);
            Console.WriteLine(zeroRatio);


        }
    }
}
