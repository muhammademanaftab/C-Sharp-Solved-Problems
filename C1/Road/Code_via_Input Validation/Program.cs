using System;

namespace Road
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total_length = 0;
            int stages = 0;
            bool good;

            do
            {
                Console.WriteLine("Enter the Total Length Of Road and Stages ");
                string input = Console.ReadLine();
                good = int.TryParse(input.Split(' ')[0], out total_length) && total_length >= 1 && total_length <= 10000 &&
                    int.TryParse(input.Split(' ')[1], out stages) && stages >= 1 && stages <= 100;



                if (!good)
                {

                    Console.WriteLine("Wrong Input");
                }
            }

            while (!(good));


            int[] start = new int[stages];
            int[] end = new int[stages];

            Console.WriteLine("Start must be greater than zero and End must be greater than start and less than Total Length");
            for (int i = 0; i < stages; i++)
            {
                do
                {
                    string input = Console.ReadLine();
                    good = int.TryParse(input.Split(' ')[0], out start[i]) && start[i] >= 0 &&
                           int.TryParse(input.Split(' ')[1], out end[i]) && end[i] > start[i] && end[i] <= total_length;

                    if (!(good))
                    {
                        Console.WriteLine("Wrong Input");
                    }

                } while (!(good));

            }

            int shortest_distance = end[0] - start[0];

            for (int i = 0; i < stages; i++)
            {
                if ((end[i] - start[i]) < shortest_distance)
                {
                    shortest_distance = end[i] - start[i];
                }
            }

            Console.WriteLine(shortest_distance);
            Console.ReadLine();

        }
    }
}
