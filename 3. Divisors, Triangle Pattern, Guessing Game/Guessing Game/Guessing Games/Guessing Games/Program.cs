using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program 1------------------ Game 1

            Console.WriteLine("1. First Game in which User Guess the Number!");
            Random rnd = new Random();
            int num = rnd.Next(1, 101);
            Console.WriteLine("Computer Selected his Number.");
            int guess;
            for (int i = 1; i <= 10; i++)
            {
                if (i == 1)
                {
                    Console.Write("Guess: ");
                }
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == num)
                {
                    Console.WriteLine("Congrats! You Guess the Right Number in {0} attempt and you won the game. Press Enter to EXIT!", i);
                    break;
                }
                else if (i == 10)
                {
                    Console.WriteLine("The Number is : {0}", num);
                    Console.WriteLine("All Guesses Finished & You Lose. Press Enter to EXIT!");
                }
                else
                {
                    Console.Write("Guess Again: ");
                }

            }
            Console.ReadLine();



            // Program 2 --------------------- Game 2

            //Console.WriteLine("2. Second Game in which Computer Guess the Number!");
            //Console.Write("Give any Number to be guessed by computer: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Random rnd = new Random();
            //for (int i = 1; i <= 10; i++)
            //{
            //    int guess = rnd.Next(1, 101);
            //    Console.Write("Guess of Computer: {0}", guess);
            //    Console.WriteLine();
            //    if (guess == num)
            //    {
            //        Console.WriteLine("You Lose! Computer Guessed The Right Number {0}. Press Enter to EXIT!", guess);
            //        break;
            //    }
            //    else if (i == 10)
            //    {
            //        Console.WriteLine("Congrats! You Won & Computer Lose the Game. Press Enter to EXIT!");
            //    }
            //}
            //Console.ReadLine();


        }
    }
}
