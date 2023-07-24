using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms
{
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {

            bool result = false;
            List<char> sList = s.ToCharArray().ToList();
            List<char> tList = t.ToCharArray().ToList();

            if (sList.Count == tList.Count)
            {

                for (int i = 0; i < sList.Count; i++)
                {
                    var charr = sList[i];

                    if (tList.Contains(charr))
                    {

                        tList.Remove(charr);
                        sList.Remove(charr);
                        i--;


                    }
                    else
                    {

                        return false;
                    }
                }




            }
            else
            {
                return false;
            }

            if (sList.Count == 0 && tList.Count == 0)
            {
                return true;
            }



            return false;
        }
    }
}
