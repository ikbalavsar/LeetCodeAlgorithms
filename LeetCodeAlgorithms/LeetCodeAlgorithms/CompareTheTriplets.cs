using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    public class CompareTheTriplets
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var score1 = 0;
            var score2 = 0;

            for (int i = 0; i < a.Count(); i++)
            {
                var alice = a[i];
                var bob = b[i];

                if (alice > bob)
                {
                    score1++;
                }
                else if (bob > alice)
                {
                    score2++;
                }


            }

            List<int> resultList = new List<int>();
            resultList.Add(score1);
            resultList.Add(score2);

            return resultList;

        }
    }
}
