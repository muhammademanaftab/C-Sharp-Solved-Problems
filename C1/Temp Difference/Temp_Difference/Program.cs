using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = 0;

            do
            {
                days = Convert.ToInt32(Console.ReadLine());
            } while (!(days >= 1 && days <= 100));

            int[] maxt = new int[days];
            int[] mint = new int[days];

            for (int i = 0; i < days;)
            {
                string input = Console.ReadLine();
                mint[i] = Convert.ToInt32(input.Split(' ')[0]);
                maxt[i] = Convert.ToInt32(input.Split(' ')[1]);
                if ((mint[i] >= -50 && mint[i] <= 50 && maxt[i] >= -50 && maxt[i] <= 50) || (maxt[i] <= mint[i]))
                {
                    i++;
                }
            }

            //Task
            int minindex = 0;
            int minval = maxt[0] - mint[0];
            for (int i = 0; i < days; i++)
            {
                if ((maxt[i] - mint[i]) < minval)
                {
                    minindex = i;
                    minval = (maxt[i] - mint[i]);
                }
            }
            Console.WriteLine(minindex + 1);
            Console.ReadLine();

        }
    }
}
