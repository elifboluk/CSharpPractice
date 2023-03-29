using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_For_Loop_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string[] dizi = { "df", "", "" };
            string bubirstr = "fun&!! time";
            //Console.WriteLine(HackerrankSolution.LongestWord(bubirstr));
            // ForLoopQ.QuestionBasicExample7();
            //Console.WriteLine(HackerrankSolution.findDigits(1202));
            List<int> arr = new List<int>() {7, 2, 5, 3, 5, 3};
            List<int> brr = new List<int>() {7, 2, 5, 4, 6, 3, 5, 3};
            List<int> sonuc = new List<int>(); 
            sonuc=HackerrankSolution.missingNumbers(arr,brr);
            foreach (var item in sonuc)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}