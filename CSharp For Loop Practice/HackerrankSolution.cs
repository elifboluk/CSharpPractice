using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_For_Loop_Practice
{
    public class HackerrankSolution
    {
        // The Hurdle Race
        public static int hurdleRace(int k, List<int> height)
        {
            int big = height[0];
            for (int i = 0; i < height.Count - 1; i++)
            {
                if (height[i + 1] > big)
                {
                    big = height[i + 1];
                }
            }
            if (big < k) { return 0; }
            var res = big - k;
            return res;
        }

        // The Birthday Bar
        public static int birthday(List<int> s, int d, int m)
        {
            int ctr = 0;
            var newlist = new List<int> { };
            for (int i = 0; i < s.Count - m + 1; i++)
            {
                for (int j = i; j < i + m; j++)
                {
                    newlist.Add(s[j]);
                }
                if (d == newlist.Sum())
                {
                    ctr++;
                }
                newlist.Clear();
            }
            return ctr;
        }
    }
}
