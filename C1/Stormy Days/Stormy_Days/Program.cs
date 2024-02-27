using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stormy_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CountDays = 0;
            int CompDays = 0;
            bool good;

            do
            {
                Console.WriteLine("Enter Total Days And Competition Days: "); string input = Console.ReadLine();
                good = int.TryParse(input.Split(' ')[0], out CountDays) && CountDays >= 1 && CountDays <= 100 &&
                    int.TryParse(input.Split(' ')[1], out CompDays) && CompDays >= 1 && CompDays <= 200;

                if (!(good))
                {
                    Console.WriteLine("Wrong Input");
                }
            } while (!(good));

            int[] SpeedWind = new int[CountDays];

            for (int i = 0; i < CountDays; i++)
            {

                Console.WriteLine("Enter Speed of Wind for Day {0}", i + 1);
                do
                {
                    good = int.TryParse(Console.ReadLine(), out SpeedWind[i]) && SpeedWind[i] >= 0 && SpeedWind[i] <= 200;

                    if (!(good))
                    {
                        Console.WriteLine("Wrong Input");
                    }

                } while (!(good));

            }
            int count = 0;

            for (int i = 0; i < CountDays; i++)
            {
                if (SpeedWind[i] > 100)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
