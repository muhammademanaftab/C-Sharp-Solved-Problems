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
            int cities= Convert.ToInt32(Console.ReadLine());
            int[] distances= new int[cities];
            int[] prices= new int[cities];
            for (int i=0; i<cities; i++)
            {
                string input = Console.ReadLine();
                distances[i] = Convert.ToInt32(input.Split(' ')[0]);
                prices[i] = Convert.ToInt32(input.Split(' ')[1]);
                
            }
            int max_distance = 0;
            int max_price = 0;
            for (int i=0;i<cities; i++)
            {
                if (max_distance < distances[i] ) {
                    max_distance = distances [i];
                    max_price = prices[i];
                }
                else if (max_distance == distances[i] && max_price > prices[i])
                {
                    max_distance = distances[i];
                    max_price = prices[i];
                }
            }
            Console.WriteLine(max_price);
            Console.ReadLine();

        }
    }
}
