using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Program ---------- 1
            /* Console.WriteLine("Give a Number: ");

            int n = Convert.ToInt32 (Console.ReadLine());
            int fac = 1;
            for (int i = 0; i<n; i++)
            {
                fac = fac * (n - i);
            }
            Console.WriteLine(fac);
            Console.ReadLine();
            */

            // Program 2---------------
            /*
            Console.Write("Give a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                } 
            }
            Console.WriteLine("The sum of divisor are: {0}",sum);
            Console.ReadLine();
            */

            //Program 3 -----------------
            /*
            Console.Write("Give a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if ((n % i == 0) && (i % 2 != 0))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum of divisors that are Odd: {0}", sum);
            Console.ReadLine();
            */

            // Program 4 -------------------
            /*
            Console.Write("Give a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
            Console.WriteLine("The square of number {0} is {1}" ,i,  (i *i ));
                
            }
            Console.ReadLine();

            */

            // Program 5 -------------------
            /*
            Console.Write("Give a Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
            Console.WriteLine("The square of number {0} is {1}" ,i,  (i *i ));
                
            }
            Console.ReadLine();

            */

            // Program 4 -------------------

            //Console.Write("Enter a Number: ");
            //int num= Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= num; i++)
            //{
            //    if (i == 1)
            //    {
            //        sum = 1;
            //        Console.WriteLine(sum);
            //    }
            //    else
            //    {
            //    Console.Write("{0} + {1} = ",sum,i);
            //    sum = sum + i;
            //    Console.WriteLine(sum);
            //    }

            //}
            //    Console.ReadLine();


            //Program 5 ----------------------

            //    Console.Write("Enter a Number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    double PowerTwo = 0;
            //    int index = 0;
            //    for (int i = 0; i < num; i++) {
            //    if (Math.Pow (2, i) < num )
            //        {
            //            PowerTwo = Math.Pow (2,i);
            //            index = i;

            //        }
            //    }
            //    Console.WriteLine("Power of Two smallar than number is {0} and value is {1} .", index,PowerTwo);    
            //    Console.ReadLine();
            //}

            //Program 7-----------------

            //Console.Write("Enter a Number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    Console.Write("* ");
            //}
            //Console.ReadLine();

            //Program 8 ------------------------

            //    Console.Write("Enter a Length: ");
            //    int length = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter a Width: ");
            //    int width = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 0; i < length; i++) { 
            //    if (i == 0)
            //        {
            //            for (int j = 0; j < width; j++)
            //            {
            //                Console.Write("* ");
            //            }
            //            Console.WriteLine  ();
            //        }
            //    else if (i == length-1) {
            //            for (int k = 0; k < width; k++)
            //            {
            //                Console.Write("* ");
            //            }
            //            Console.WriteLine();
            //        }
            //    else
            //        {
            //            Console.Write("* ");
            //            for (int l = 2; l < width; l++)
            //            {
            //                Console.Write("  ");
            //            }

            //            Console.WriteLine("* ");
            //        }
            //    }
            ////    Console.ReadLine();
            ///

            //}

            //Program 11 ---------------
            //    Console.WriteLine("Choose The Program: ");
            //    Console.WriteLine("For Addition Press: A/a \nFor Multiplication Press: M/m \nFor Swapping Press: S/s");
            //    string program = Console.ReadLine();
            //    Console.Write("First Number: ");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Second Number: ");
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    if (program == "a" || program == "A")
            //    {
            //        Console.WriteLine("Sum is: {0}", a + b);
            //    }
            //    if (program == "m" || program == "M")
            //    {
            //        Console.WriteLine("Product is : {0}", a * b);
            //    }
            //    if (program == "s" || program == "S")
            //    {
            //        Console.WriteLine("Before Swapping : {0} {1} ", a, b);
            //        int temp = a;
            //        a = b; b = temp;
            //        Console.WriteLine("After Swapping : {0} {1}", a, b);
            //    }

            //    Console.ReadLine();
            //}

            //Program 12 --------------

            //Console.Write("Enter Number To Generate Ulam Sequence: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("{0} -> ",num);
            //while (num != 1)
            //{

            //    if (num % 2 == 0)
            //    {
            //        num = (num / 2);
            //        Console.Write(num);

            //    }

            //    else
            //    {
            //        num = ((3 * num) + 1);
            //        Console.Write(num);

            //    }

            //    if (num != 1)
            //    {
            //        Console.Write(" -> ");
            //    }

            //}
            //Console.ReadLine();

            //Program 13 ---------------

            //Console.WriteLine("Enter a Number: ");
            //string input = Console.ReadLine();
            //int len = input.Length;
            //string Modifinput="";

            //for (int i = 0; i < len; i++)
            //{

            //    if (input[i] == '0')
            //    {

            //        Modifinput += '5' ;
            //    }
            //    else
            //    {
            //        Modifinput += input[i] ;

            //    }
            //}
            //    Console.WriteLine("Modified String: " + Modifinput);
            //    Console.ReadLine();

            //Prgoram 14 --------------

            //    Console.Write("Enter Number: ");
            //    int num = Convert.ToInt32((Console.ReadLine()));
            //    int reverse = 0;
            //    Console.Write("Reversed Number is: " );
            //    while (num != 0)
            //    {
            //        reverse = num % 10;
            //        num = num / 10;
            //        Console.Write(reverse);
            //    }
            //    Console.ReadLine();
            //}

            //Program 15 ----------------

        //    Console.Write("Enter a Number: ");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    int originalNum = num; 
        //    int len = num.ToString().Length;
        //    int digit, sum = 0;

        //    while (num > 0)
        //    {
        //        digit = num % 10;
        //        sum += (int)Math.Pow(digit, len);
        //        num /= 10;
        //    }

        //    if (sum == originalNum)
        //    {
        //        Console.WriteLine("The number is an Armstrong Number.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The number is not an Armstrong Number.");
        //    }

        //    Console.ReadLine();


        //    Console.ReadLine();

        //}
    }
}