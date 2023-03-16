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

        public static string LongestWord(string sen)
        {
            //List<char> yeniliste = sen.ToList();
            char[] silinecek = { '&', '!', '?', ',', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //for (int i = 0; i < yeniliste.Count; i++)
            //{
            //    if (silinecek.Contains(yeniliste[i]))
            //    {
            //       yeniliste.RemoveAt(i);
            //    }
            //}
            sen.Except(silinecek);

            string[] kelime = sen.Split(' ');
            int[] sayi = new int[kelime.Length];
            for (int i = 0; i < kelime.Length; i++)
            {
                sayi[i] = kelime[i].Length;
            }
            int buyukdeger = sayi[0];
            for (int i = 1; i < sayi.Length; i++)
            {
                if (sayi[i] > buyukdeger)
                {
                    buyukdeger = sayi[i];
                }
            }
            var degisken = Array.IndexOf(sayi, buyukdeger);
            return kelime[degisken];

        }

        // Electronics Shop
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (keyboards[i] + drives[j] <= b)
                    {
                        result.Add(keyboards[i] + drives[j]);
                    }
                }
            }
            if (result.Count != 0)
            {
                return result.Max();
            }
            return -1;
        }
    }
}
