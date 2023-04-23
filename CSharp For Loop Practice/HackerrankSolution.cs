using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        // Longest Word
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

        // Picking Numbers
        public static int pickingNumbers(List<int> a)
        {
            a.Sort();
            int ctr = 1;
            List<int> e = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (a[j] - a[i] == 1 || a[j] - a[i] == 0)
                    {
                        ctr++;
                    }
                }
                e.Add(ctr);
                ctr = 1;
            }
            return e.Max();
        }

        // Utopian Tree
        public static int utopianTree(int n)
        {
            int height = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    height += 1;
                }
                if (i % 2 == 1)
                {
                    height = height * 2;
                }
            }
            return height;
        }

        // Save The Prisoner!
        public static int saveThePrisoner(int n, int m, int s)
        {
            int sum = m + s - 1;
            int result = sum % n;
            if (result == 0) { return n; }
            return result;
        }

        // Angry Professor
        public static string angryProfessor(int k, List<int> a)
        {
            var ctr = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] <= 0)
                {
                    ctr++;
                }
            }
            if (ctr < k)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }

        }

        // Find Digits
        public static int findDigits(int n)
        {
            int ctr = 0;
            string m = n.ToString();            
            for (int i = 0; i < m.Length; i++)
            {
                //string a = m[i].ToString();
                int hane = Convert.ToInt32(m[i].ToString()); // Convert.ToInt32(m[i]) içerisine char girince ascii koduna çeviriyor. Bu yüzden ToString() ile stringe çevirip kullanıyoruz!!! 
                if (hane > 0 && n % hane == 0 ) // Kod soldan sağa doğru okunur. Bu yüzden önce "sıfırdan büyük mü?" diye kontrol ettirdik. 
                {
                    ctr++;
                }
            }
            return ctr;
        }

        // Missing Numbers (To be continued...)
        public static List<int> missingNumbers(List<int> arr, List<int> brr)
        {
            // arr = {7, 2, 5, 3, 5, 3};
            // brr = {7, 2, 5, 4, 6, 3, 5, 3 };
            var ctr = 0;
            var ctr2 = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < brr.Count; i++)
            {
                var degisken = brr[i];
                for (int k = 0; k < brr.Count; k++)
                {
                    if (brr[k] == degisken)
                    {
                        ctr++;
                    }
                }
                
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[j] == degisken)
                    {
                        ctr2++;
                    }
                }

                if (ctr != ctr2 && !result.Contains(brr[i]))
                {
                    result.Add(brr[i]);
                }
                ctr = 0;
                ctr2 = 0;
            }
            result.Sort();
            return result;
        }

        // Extra Long Factorials
        public static void extraLongFactorials(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = i * result; // using System.Numerics;
            }
            Console.WriteLine(result);
        }

        // Lonely Integer
        public static int lonelyinteger(List<int> a)
        {
            int ctr = 0;
            int result = 0;
            for (int i = 0; i < a.Count; i++)
            {
                var gecici = a[i];
                for (int j = 0; j < a.Count; j++)
                {
                    if (gecici == a[j])
                    {
                        ctr++;
                    }
                }
                if (ctr == 1)
                {
                    result = a[i];
                }
                ctr = 0;
            }
            return result;

        }

        // Maximum Toys
        public static int maximumToys(List<int> prices, int k)
        {
            var ctr = 0;
            var sumo = 0;
            prices.Sort();
            for (int i = 0; i < prices.Count; i++)
            {
                sumo += prices[i];
                ctr++;
                if (sumo > k)
                {
                    break;
                }
            }
            return ctr - 1;
        }

        // Minimum Number
        public static int minimumNumber(int n, string password)
        {
            // #HackerRank
            var numbers = "0123456789";
            var lower_case = "abcdefghijklmnopqrstuvwxyz";
            var upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var special_characters = "!@#$%^&*()-+";
            int ctr = 4;
            int ctr1 = 1;
            int ctr2 = 1;
            int ctr3 = 1;
            int ctr4 = 1;
            for (int i = 0; i < password.Length; i++)
            {
                if (numbers.Contains(password[i]) && ctr1 == 1)
                {
                    ctr1--;
                    ctr--;
                }

                if (lower_case.Contains(password[i]) && ctr2 == 1)
                {
                    ctr2--;
                    ctr--;
                }

                if (upper_case.Contains(password[i]) && ctr3 == 1)
                {
                    ctr3--;
                    ctr--;
                }

                if (special_characters.Contains(password[i]) && ctr4 == 1)
                {
                    ctr4--;
                    ctr--;
                } // ctr=1;
                  // Length=3                
            }
            if (password.Length + ctr < 6)//IGEC =4 ve ctr=3
            {
                ctr += 6 - password.Length - ctr;
            }
            return ctr;
        }

        // Camel Case
        public static int camelcase(string s)
        {
            int ctr = 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    ctr++;
                }
            }
            return ctr;
        }

    }
}
