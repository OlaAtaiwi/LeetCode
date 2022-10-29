using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    class SingleNumber
    {

        public static int singleNumber(int[] nums)
        {
            int r = 0;
            foreach (var i in nums)
                r ^= i;
            return r;
            //with no constrains mentioned in LeetCode Description
            /*Dictionary<int, int> mydic = new Dictionary<int, int>();
              foreach(var i in nums)
              {
                  if (mydic.ContainsKey(i) == false)
                      mydic.Add(i, 1);
                  else
                      mydic[i] += 1;
              }
              foreach (KeyValuePair<int, int> pair in mydic)
                  if (pair.Value == 1)
                      return pair.Key;
          return -1;*/
        }
    }
}
