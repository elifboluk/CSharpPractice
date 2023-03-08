using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_For_Loop_Practice
{
    public class ForLoopQ
    {
        public static void Question1()
        {
            /* 
                Write a program in C# Sharp to display the first 10 natural numbers.
                Expected Output : 1 2 3 4 5 6 7 8 9 10 
            */
            Console.WriteLine("The first 10 natural number is:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }
        }

        public static void Question2()
        {
            /*
                Write a C# Sharp program to find the sum of first 10 natural numbers.
                The first 10 natural number is : 1 2 3 4 5 6 7 8 9 10
                The Sum is : 55
            */
            Console.WriteLine("The first 10 natural number is:");
            int ctr = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
                ctr = ctr + i;
            }
            Console.Write("\n\n");
            Console.Write("The Sum is:");
            Console.Write(ctr);
        }

        public static void Question3()
        {
            /*
                Write a program in C# Sharp to display n terms of natural number and their sum. 
                Test Data : 7
                Expected Output :
                The first 7 natural number is : 1 2 3 4 5 6 7
                The Sum of Natural Number upto 7 terms : 28
            */

            Console.WriteLine("Please enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int ctr = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0} ", i);
                ctr = ctr + i;
            }
            Console.Write("\n\n");
            Console.Write("The Sum of Natural Number upto {0} terms :", number);
            Console.Write(ctr);
        }

        public static void Question4()
        {
            /*
                Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
                Test Data :
                Input the 10 numbers :
                Number-1 :2
                ...
                Number-10 :2
                Expected Output :
                The sum of 10 no is : 51
                The Average is : 5.100000
            */
            int sum = 0;
            double avg = 0;
            Console.WriteLine("Please enter 10 numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Number {0}: ", i);
                sum += Convert.ToInt32(Console.ReadLine());
            }
            avg = sum / 10.0;
            Console.WriteLine("The sum of 10 number is: {0} \nThe averrage is: {1}", sum, avg);

        }

        public static void Question5()
        {
            /*
                Write a program in C# Sharp to display the cube of the number up to given an integer.
                Test Data :
                Input number of terms : 5
                Expected Output :
                Number is : 1 and cube of the 1 is :1
                Number is : 2 and cube of the 2 is :8
                Number is : 3 and cube of the 3 is :27
                Number is : 4 and cube of the 4 is :64
                Number is : 5 and cube of the 5 is :125
            */
            Console.Write("Please enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int cube = i * i * i;
                Console.WriteLine("Number is : {0} and cube of the {0} is :{1} ", i, cube);
            }
        }

        public static void Question6()
        {
            /*
                Write a program in C# Sharp to display the multiplication table of a given integer.
                Test Data :
                Input the number (Table to be calculated) : 15
                Expected Output :15 X 1 = 15
                                 ...
                                 15 X 10 = 150
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", number, i, number * i);
            }
        }

        public static void Question7()
        {
            /*
                Write a program in C# Sharp to display the multiplication table vertically from 1 to n.
                Test Data :
                Input upto the table number starting from 1 : 8
                Expected Output :
                Multiplication table from 1 to 8
                1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
                ...
                1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80 
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} X {1} = {2}, ", j, i, j * i);

                }
                Console.Write("\n");
            }
        }

        public static void Question8()
        {
            /*
            Write a program in C# Sharp to display the n terms of odd natural number and their sum.
            Test Data
            Input number of terms : 10
            Expected Output :
            The odd numbers are :1 3 5 7 9 11 13 15 17 19
            The Sum of odd Natural Number upto 10 terms : 100
            */

            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int odd = 1;
            int sum = 0;
            Console.Write("The odd numbers are: ");
            for (int i = 1; i <= number; i++)
            {
                sum += odd;
                Console.Write("{0} ", odd);
                odd += 2;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of odd Natural Number upto {0} terms: {1} ", number, sum);
        }

        public static void Question9()
        {
            /*
            Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
            The pattern like :
                *
                **
                ***
                ****
            */
            Console.Write("Please, enter the line number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string star = "*";
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", star);
                }
                Console.WriteLine();
            }
        }

        public static void Question10()
        {
            /*
                Write a program in C# Sharp to display the pattern like right angle triangle with a number.
                The pattern like :
                1
                12
                123
                1234
            */
            Console.Write("Please, enter the line number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                }
                Console.WriteLine();
            }
        }

        public static void Question11()
        {
            /*
                Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row.
                The pattern like :
                1
                22
                333
                4444
            */
            Console.Write("Please, enter the line number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", i);
                }
                Console.WriteLine();
            }
        }

        public static void Question12()
        {
            /*
                Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1. 
                The pattern like :
                1
                2 3
                4 5 6
                7 8 9 10 
            */
            Console.Write("Please, enter the line number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int ctr = 0;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    ctr++;
                    Console.Write("{0} ", ctr);
                }
                Console.WriteLine();
            }
        }

        public static void Question15()
        {
            /*
                Write a C# Sharp program to calculate the factorial of a given number.
                Test Data :
                Input the number : 5
                Expected Output :
                The Factorial of 5 is: 120
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("The Factorial of {0} is: {1} ", number, factorial);
        }

        public static void Question16()
        {
            /*
                Write a program in C# Sharp to display the n terms of even natural number and their sum.
                Test Data :
                Input number of terms : 5
                Expected Output :
                The even numbers are :2 4 6 8 10
                The Sum of even Natural Number upto 5 terms : 30
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int even = 0;
            int sum = 0;
            Console.Write("The even numbers are :");
            for (int i = 1; i <= number; i++)
            {
                even += 2;
                Console.Write("{0} ", even);
                sum = even + sum;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of even Natural Number upto {0} terms : {1}", number, sum);
        }

        public static void Question19()
        {
            /*
            Write a program in C# Sharp to display the n terms of harmonic series and their sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
            Test Data :
            Input the number of terms : 5
            Expected Output :
            1/1 + 1/2 + 1/3 + 1/4 + 1/5 +
            Sum of Series upto 5 terms : 2.283334
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum = sum + (1 / Convert.ToDouble(i));
                Console.Write("1/{0} ", i);
            }
            Console.WriteLine("\nSum of Series upto {0} terms :{1}", number, sum);
        }

        public static void Question21()
        {
            /*
                Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
                Test Data :
                Input the number or terms :5
                Expected Output :
                9 99 999 9999 99999
                The sum of the series = 111105
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            string str = "9";
            for (int i = 1; i <= number; i++)
            {
                sum = Convert.ToInt32(str) + sum;
                // sum = 9   + sum
                // 9   = 0   + 9
                // 108 = 99  + 9
                // 1107= 999 + 108
                Console.Write("{0} ", str);
                str += "9";
            }
            Console.WriteLine("\nThe sum of the series = {0}", sum);
        }

        public static void Question22()
        {
            /*
                Write a program in C# Sharp to print the Floyd's Triangle.
                The pattern like:
                1
                01 
                101
                0101 
                10101 
            */
            Console.Write("Please, enter the line number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write("1");
                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        if (j % 2 == 1)
                        {
                            Console.Write("0");
                        }
                        else
                        {
                            Console.Write("1");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void Question24()
        {
            /*
                Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -...].
                Test Data :
                Input the value of x : 2
                Input number of terms : 5
                The sum = 410
                Number of terms = 5
                The value of x = 2 
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the value of x: ");
            int value_x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int ctr = 1;
            for (int i = 1; i <= number; i++)
            {
                int multiple = 1;
                for (int j = 1; j <= ctr; j++)
                {
                    multiple = multiple * value_x;
                }
                ctr += 2;
                if (i % 2 == 1)
                {
                    sum = sum + multiple;
                }
                else
                {
                    sum = sum - multiple;
                }
            }
            Console.WriteLine("The sum = {0} \nNumber of terms = {1} \nThe value of x = {2} ", sum, number, value_x);
        }

        public static void Question25()
        {
            /*
                Write a program in C# Sharp to display the n terms of square natural number and their sum. 1 4 9 16 ... n Terms
                Test Data :
                Input the number of terms : 5
                Expected Output :
                The square natural upto 5 terms are :1 4 9 16 25
                The Sum of Square Natural Number upto 5 terms = 55
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int square = 1;
            Console.Write("The square natural upto {0} terms are : ", number);
            for (int i = 1; i <= number; i++)
            {
                square = i * i;
                Console.Write(square + " ");
                sum = square + sum;
            }
            Console.WriteLine("\nThe Sum of Square Natural Number upto {0} terms = {1}", number, sum);
        }

        public static void Question26()
        {
            /*
                Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.
                Test Data :
                Input the number of terms : 5
                Expected Output :
                1 + 11 + 111 + 1111 + 11111
                The Sum is : 12345
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            string series = "";
            string str = "1";
            for (int i = 1; i <= number; i++)
            {
                series = str + series;
                // 1      = 1   + "" 
                // 11     = 1   + 1
                // 111    = 1   + 11
                if (i < number)
                {
                    Console.Write("{0} + ", series);
                }
                else
                {
                    Console.Write("{0}", series);
                }
                sum += Convert.ToInt32(series);
            }
            Console.WriteLine("\nThe Sum is:{0}", sum);
        }

        public static void Question27()
        {
            /*
            Write a C# Sharp program to check whether a given number is perfect number or not.
            Test Data :
            Input the number : 56
            Expected Output :
            The positive divisor : 1 2 4 7 8 14 28
            The sum of the divisor is : 64
            So, the number is not perfect.             
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Write("The positive divisor :");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(" " + i);
                    sum += i;
                }
            }
            Console.WriteLine("\nThe sum of the divisor is : {0}", sum);
            if (sum == (number * 2))
            {
                Console.WriteLine("The number {0} is perfect!", number);
            }
            else
            {
                Console.WriteLine("The number {0} is not perfect!", number);
            }
        }

        public static void Question28()
        {
            /*
                Write a C# Sharp program to find the perfect numbers within a given range of number.
                Test Data :
                Input the starting range of number : 1
                Input the ending range of number : 50
                Expected Output :
                The Perfect numbers within the given range : 6 28
            */
            Console.Write("Please, enter the starting range of number: ");
            int s_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the ending range of number: ");
            int e_number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.Write("The Perfect Numbers within the given range :");
            for (int i = s_number; i <= e_number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == (i * 2))
                {
                    Console.Write(i + " ");
                }
                sum = 0;
            }
        }

        public static void Question29()
        {
            /*
                Write a C# Sharp program to check whether a given number is an Armstrong number or not.
                Test Data :
                Input a number: 153
                Expected Output :
                153 is an Armstrong number.
            */
            Console.Write("Please, enter the number: ");
            string number = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int x = Convert.ToInt32(number[i].ToString());
                sum += x * x * x;
            }
            if (sum == Convert.ToInt32(number))
            {
                Console.WriteLine("{0} is an Armstrong number.", number);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number.", number);
            }
        }

        public static void Question30()
        {
            /*
                Write a C# Sharp program to find the Armstrong number for a given range of number.
                Test Data :
                Input starting number of range: 1
                Input ending number of range : 1000
                Expected Output :
                Armstrong numbers in given range are: 1 153 370 371 407            
            */
            Console.Write("Please, enter the starting range of number: ");
            string s_number = Console.ReadLine();
            Console.Write("Please, enter the ending range of number: ");
            string e_number = Console.ReadLine();
            int sum = 0;
            Console.Write("Armstrong numbers in given range are: ");
            for (int i = Convert.ToInt32(s_number); i <= Convert.ToInt32(e_number); i++)
            {
                string number = i.ToString();
                for (int j = 0; j < number.Length; j++)
                {
                    int x = Convert.ToInt32(number[j].ToString());
                    sum += x * x * x;
                }

                if (sum == Convert.ToInt32(i.ToString()))
                {
                    Console.Write(i + " ");
                }
                sum = 0;
            }
        }

        public static void Question32()
        {
            /*
                Write a C# Sharp program to determine whether a given number is prime or not.
                Test Data :
                Input a number: 13
                Expected Output :
                13 is a prime number.
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int ctrl = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    ctrl++;
                }
            }
            if (ctrl == 2 && number > 1)
            {
                Console.WriteLine("{0} is a prime number", number);
            }
            else if (number == 1)
            {
                Console.WriteLine("{0} is a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is a not prime number", number);
            }
        }

        public static void Question34()
        {
            /*
                Write a program in C# Sharp to find the prime numbers within a range of numbers.
                Test Data :
                Input starting number of range: 1
                Input ending number of range : 50
                Expected Output :
                The prime number between 1 and 50 are :
                2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            */
            Console.Write("Please, enter the starting range of number: ");
            int s_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the ending range of number: ");
            int e_number = Convert.ToInt32(Console.ReadLine());
            int ctrl = 0;
            for (int i = s_number; i < e_number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        ctrl++;
                    }
                }
                if (ctrl == 2 && i > 1)
                {
                    Console.Write(i + " ");
                }
                ctrl = 0;
            }
        }

        public static void Question35()
        {
            /*
                Write a program in C# Sharp to display the first n terms of Fibonacci series.
                Fibonacci series 0 1 2 3 5 8 13 ...
                Test Data :
                Input number of terms to display : 10
                Expected Output :
                Here is the Fibonacci series upto to 10 terms :
                0 1 1 2 3 5 8 13 21 34
            */
            Console.Write("Please, enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int first_term = 0;
            int second_term = 1;
            int third_term = 0;
            Console.Write(first_term + " " + second_term + " ");
            for (int i = 2; i < number; i++)
            {
                third_term = first_term + second_term;
                Console.Write(third_term + " ");
                first_term = second_term;
                second_term = third_term;
            }
        }

        public static void Question37()
        {
            /*
            Write a program in C# Sharp to display the number in reverse order.
            Test Data :
            Input a number: 12345
            Expected Output :
            The number in reverse order is : 54321
            */
            Console.Write("Please, enter the number: ");
            string number = Console.ReadLine();
            string reverse_number = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reverse_number += number[i];
            }
            Console.Write("The number in reverse order is : {0}", reverse_number);
        }

        public static void Question38()
        {
            /*
                Write a program in C# Sharp to check whether a number is a palindrome or not.
                Test Data :
                Input a number: 121
                Expected Output :
                121 is a palindrome number.
            */
            Console.Write("Please, enter the number: ");
            string number = Console.ReadLine();
            string reverse_number = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reverse_number += number[i];
            }
            if (reverse_number == number)
            {
                Console.Write("{0} is a palindrome number.", reverse_number);
            }
            else
            {
                Console.Write("{0} is not a palindrome number.", number);
            }
        }

        public static void Question39()
        {
            /*
                Write a program in C# Sharp to find the number and sum of all integer between 100 and 200 which are divisible by 9.
                Expected Output :
                Numbers between 100 and 200, divisible by 9 :
                108 117 126 135 144 153 162 171 180 189 198
                The sum : 1683
            */
            Console.Write("Please, enter the starting range of number: ");
            int s_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the ending range of number: ");
            int e_number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the divisible number: ");
            int d_number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            Console.WriteLine("Numbers between {0} and {1}, divisible by {2} :", s_number, e_number, d_number);
            for (int i = s_number; i <= e_number; i++)
            {
                if (i % d_number == 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine("\nThe sum: {0}", sum);
        }

        public static void Question40()
        {
            /*
                Write a C# Sharp Program to display the following pattern using the alphabet.
                A
                A B A
                A B C B A
                A B C D C B A              
            */

        }

        public static void QuestionStarShifter()
        {
            /*
                Write a C# Sharp Program to display the following pattern.
                ----*** 
                ---***-
                --***--
                -***---
                ***----            
            */
            string threeStars = "***";
            string hyphen = "-";
            int ctr = 4;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (ctr == i)
                    {
                        Console.Write(threeStars);
                    }
                    else
                    {
                        Console.Write(hyphen);
                    }
                }
                ctr--;
                Console.WriteLine();
            }
        }

        public static void QuestionStarShifter2()
        {
            /*
                Write a C# Sharp Program to display the following pattern.                
                ----*** ***----
                ---***- -***---
                --***-- --***--
                -***--- ---***-
                ***---- ----***           
            */

            string threeStars = "***";
            string hyphen = "-";
            int ctr = 4;
            int ctr2 = 6;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 11; i++)
                {
                    if (ctr == i || ctr2 == i)
                    {
                        Console.Write(threeStars);
                    }
                    else if (i == 5)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(hyphen);
                    }
                }
                ctr--;
                ctr2++;
                Console.WriteLine();
            }
        }

        public static void QuestionPlusPattern()
        {
            /*
                Write a C# Sharp Program to display the following pattern.
                sample input, for n=5;
                +-+-+
                -+-+-
                +-+-+
                -+-+-
                +-+-+ 
            */
            Console.Write("Please,enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) // or; for (int j = i; j < i+n; j++)
                {
                    if ((j + i) % 2 == 0)         // if (j%2==0)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void QuestionNewYearTree()
        {
            /*
                Write a C# Sharp Program to display the following pattern.
                       *       
                      * *
                     ** **
                    *** ***
                   **** ****
                  ***-----***
                 ****-----****
                *****-----*****
                     |   |
                     |   |
            */
            string star = "*";
            string hyphen = "-";
            string pLine = "|";
            int peak = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write(" ");
                if (i == 6)
                {
                    Console.Write(star);
                }
            }
            Console.WriteLine();
            int space = 6;
            for (int i = 1; i < 10; i++)
            {
                if (i >= 1 && i <= 4)
                {
                    for (int j = 0; j < 9 + i; j++)
                    {
                        if (j == space || j == space + (i * 2))
                        {
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write(star);
                            }
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                    space--;
                    peak++;
                }
            }
        }

        public static void QuestionBinary()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> binarylist = new List<int>();
            for (int i = 0; i >= 0; i++)
            {
                if (number == 0)
                {
                    break;
                }
                binarylist.Add(number % 2);
                number = (number - (number % 2)) / 2;
            }
            binarylist.Reverse();
            foreach (var bl in binarylist)
            {
                Console.Write(bl);
            }
        }

        public static void QuestionDecimal()
        {
            Console.WriteLine("Enter the number: ");
            string number = Console.ReadLine();
            int decimalnumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1')
                {
                    decimalnumber += Convert.ToInt32(Math.Pow(2, Convert.ToDouble(number.Length - 1 - i)));

                }
            }


            Console.WriteLine(decimalnumber);
        }

        public static void QuestionArray()
        {
            int[] ar = { 2, 7, 99, 15, 13, 3, 22, 42, 21 };
            var line = ar.ToList();
            line.Sort();
            foreach(int item in line)
            {
                Console.WriteLine(item);
            }

        }

        public static void QuestionBasicExample1()
        {
            Console.WriteLine("Please enter two number.");
            double result=Math.Pow(int.Parse(Console.ReadLine()), 2) + Math.Pow(int.Parse(Console.ReadLine()), 2);
            Console.WriteLine(result);
        }

        public static void QuestionBasicExample2()
        {
            double result = 0;
            for (int i = 1; i <= 10; i++)
            {
                result+=Math.Pow(i, 3);     
            }
            Console.WriteLine(result);
        }

        public static void QuestionBasicExample3()
        {
            // Write an application that does the multiplication of positive numbers using addition.
            Console.WriteLine("Please enter the first number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number.");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < number1; i++)
            {
                result += number2;
            }
            Console.Write("Result:");
            Console.Write(result);
            // Console.Writeline($"{number1} x {number2} = {result}");
        }

        public static void QuestionBasicExample4()
        {
            // Write an application that divides positive numbers by subtraction.
            Console.WriteLine("Please enter the first number.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number.");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < number1 ; i++)
            {
                number1 = number1 - number2;
                counter++;
                if (number1 < number2)
                    break;
            }
            Console.Write("Result:"+ counter); 
        }

        public static void QuestionBasicExample5()
        {   // Write an application that tells you how many digits the entered number has.         
            Console.WriteLine("Please enter the number.");
            int number = Convert.ToInt32(Console.ReadLine());            
            int counter = 1;
            for (; number>=10; )
            {
                number /= 10;
                counter++;                
            }
            Console.Write("Result:" + counter);
        }

        public static void QuestionBasicExample6()
        {
            Console.WriteLine("Please enter a 3-digit number.");
            int number = Convert.ToInt32(Console.ReadLine());
            int number3 = number;
            int digitnumber = 1;
            while (number3 >= 10)
            {
                digitnumber++;
                number3 /= 10;
            }
            if (digitnumber==3)
            {
                double sumcube = 0;
                int number2 = number;
                for (int i = 0; i < 3; i++)
                {
                    sumcube += Math.Pow(number2%10,3);
                    number2 = (number2 - number2 % 10) / 10;
                }
                if (sumcube == number)
                {
                    Console.WriteLine("Number is armstrong.");
                }
                else { Console.WriteLine("Number is not armstrong."); }
            }
            else { Console.WriteLine("Please enter a 3-digit number."); }
        }

        public static void QuestionBasicExample7()
        {
            Console.WriteLine("Please enter a 3-digit number.");
            string number = Console.ReadLine();
            double result = 0;
            if (number.Length!=3)
            {
                Console.WriteLine("Please enter a 3-digit number.");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    result += Math.Pow(Convert.ToDouble(number[i].ToString()), 3);
                }
                if (Convert.ToDouble(number) == result)
                {
                    Console.WriteLine("Number is armstrong.");
                }
                else { Console.WriteLine("Number is not armstrong."); }
            }
            
        }

        public int RomanToInt(string s)
        {
            int[] value = { 1, 5, 10, 50, 100, 500, 1000 };
            string symbol = "IVXLCDM";
            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += value[symbol.IndexOf(s[i])];
            }
            string[] exception = { "IV", "IX", "XL", "XC", "CD", "CM" };
            int[] exvalue = { 2, 2, 20, 20, 200, 200 };
            for (int i = 0; i < 6; i++)
            {
                if (s.Contains(exception[i]))
                {
                    result -= exvalue[i];
                }
            }
            return result;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            if (strs.Length == 0 || strs[0].Length==0) { return result; }
            for (int i = 0; i >= 0; i++)
            {
                var character = strs[0][i];
                var counter = 1;
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length-1<i)
                    {
                        break;
                    }
                    if (character.Equals(strs[j][i]))
                    {
                        counter++;
                    }
                }
                if (counter == strs.Length)
                {
                    result += character;
                }
                else
                {
                    break;
                }
            }
            return result;
        }

    }
}
