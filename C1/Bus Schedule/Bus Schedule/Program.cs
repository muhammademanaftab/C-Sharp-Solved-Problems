using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cities_number = Convert.ToInt32(Console.ReadLine());
            int[] arrival = new int[cities_number];
            int[] departure = new int[cities_number];
            string[] city = new string[cities_number];
            for (int i = 0; i < cities_number; i++)
            {
                string input = Console.ReadLine();
                city[i]= input.Split(' ')[0];
                arrival[i] = Convert.ToInt32(input.Split(' ')[1]);
                departure[i] = Convert.ToInt32(input.Split(' ')[2]);

            }
            bool exist = false;
            for (int i = 0; i < cities_number; i++)
            {
                if (city[i] == "Szekszard" && arrival[i] == -1 && departure[i] < 9999)

                {
                    exist = true;
                }
                
            }
            Console.WriteLine(exist);
            Console.ReadLine();

        }
    }
}
