using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainy_Days__B1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = Convert.ToInt32(Console.ReadLine());
            int[] fish_days = new int[days];
            int no_fish = 0;
            for (int i = 0; i < days; i++)
            {
                fish_days[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < days; i++)
            {
                if (fish_days[i] == 0 && no_fish==0 )
                {
                    no_fish = i + 1;
                }
                              

                else if (i == days - 1 && no_fish == 0)
                {
                    no_fish = -1;
                }
            }

            
            Console.WriteLine(no_fish);
            Console.ReadLine();
        }
    }
}
