using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        { /* First Program
            Console.Write("Enter Lenght :");
            int length = Convert.ToInt32 (Console.ReadLine()) ;
            Console.Write("Enter Width :");
            int width = Convert.ToInt32 (Console.ReadLine()) ;
            int area = length * width ;
            int para = ( 2 * (length + width) ) ;
            Console.Write("The Area Of Triangle : ");
            Console.WriteLine(area);
            Console.Write("The Area Of Parameter : ");
            Console.WriteLine(para);
            Console.ReadLine();
            
            Second Program

            Console.Write("Enter a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("({0}+{1})^2" ,a,b);
            Console.WriteLine("{0}^2 + 2*{0}+{1} + {1}^2 " ,a,b);
            Console.Write(a*a);
            Console.Write("+");
            Console.Write(2*a*b);
            Console.Write("+");
            Console.WriteLine(b*b);
            Console.Write((a*a)+(2*a*b)+(b*b));
            Console.ReadLine();

            Console.Write("Amount of Petrol Consumed (litres) :");
            int Consume = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length of Trip (Km) :");
            int length = Convert.ToInt32(Console.ReadLine());
            double usage = (((double) Consume/length) * 100);
            Console.Write("The Consumption of Car is : ");
            Console.WriteLine(usage);
            Console.ReadLine();

            Third Program

            Console.Write("Number of Kids : ");
            int kids = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of Apples : ");
            int apples = Convert.ToInt32(Console.ReadLine());
            int remaining= (apples % kids);
            int get = (apples/kids);
            Console.Write("Every kid gets ");
            Console.Write(get);
            Console.Write(" apples and there are ");
            Console.Write(remaining);
            Console.Write(" apples left");


            Console.ReadLine();


            Console.Write("Enter the length for side 1 :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length for side 2 : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the length for side 3 : ");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a * a) + (b * b) == (c * c) || (b * b) + (c * c) == (a * a) || (c * c) + (b * b) == (a * a))
            {
                Console.WriteLine("The given triangle is a right-angled triangle");
            } else
            {
                Console.WriteLine("The given triangle is not a right angled traingle");
            }

            Console.ReadLine();

            // Writing Program 9 -------------------
            Console.Write("Enter Words: ");
            string Longest_Word = Console.ReadLine();
            string one = (Longest_Word.Split(' ')[0]);
            string two = (Longest_Word.Split(' ')[1]);
            string three = (Longest_Word.Split(' ')[2]);

            if (Convert.ToInt32(one.Length) > Convert.ToInt32(two.Length) && Convert.ToInt32(one.Length) > Convert.ToInt32(three.Length))
            {
                Console.WriteLine("The longest word is {0}", one);
            }
            else if (Convert.ToInt32(two.Length) > Convert.ToInt32(one.Length) && Convert.ToInt32(two.Length) > Convert.ToInt32(three.Length))
            {
                Console.WriteLine("The longest word is {0}", two);
            }

            else
            {
                Console.WriteLine("The longest word is {0}", three);
            }

            Console.ReadLine();
        }
    }

            //Program 10 ------------

            Console.Write("Write Number: ");
            string digits = Console.ReadLine();
            int length= Convert.ToInt32 (digits.Length);
            if (length == 3 )
            {
                Console.WriteLine("They are 3 digits");
            }
            else
            {
                Console.WriteLine("They are not 3 digits");
            }
            Console.ReadLine();

            // Program 8 
            Console.Write("Enter two digits: ");
            string Digits = Console.ReadLine();
            int one = Convert.ToInt32( (Digits.Split (' ') [0]));
            int two = Convert.ToInt32( (Digits.Split (' ') [1]));

            if (one % 2 != 0 || two % 2 != 0) {
                Console.WriteLine("Yes there is odd one.");
            }
            else
            {
                Console.WriteLine("No one is odd.");
            }
            Console.ReadLine();

            // Program 11 ---------------
            Console.WriteLine("In the equation a*x^2 + b*x + c = 0");
            Console.Write("the value of a: ");
            double a = Convert.ToDouble (Console.ReadLine());
            Console.Write("the value of b: ");
            double b = Convert.ToDouble (Console.ReadLine());
            Console.Write("the value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double Disc = Math.Sqrt( (b * b) - (4 * a * c));
            double x1 = (-b + Disc) / (2*a);
            double x2 = (-b - Disc) / (2*a);
            Console.WriteLine("First Root is {0}" , x1);
            Console.WriteLine("Second Root is  {0}", x2);
            Console.ReadLine();
            */


        }
        
    }
} 