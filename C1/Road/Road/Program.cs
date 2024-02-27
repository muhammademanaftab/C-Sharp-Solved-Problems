namespace Road
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total_length = 0;
            int stages = 0;

            do
            {
                string input = Console.ReadLine();
                total_length = Convert.ToInt32(input.Split(' ')[0]);
                stages = Convert.ToInt32(input.Split(' ')[1]);
            }
            while (!((total_length >= 1 && total_length <= 10000) && (stages >= 1 && stages <= 100)));

            int[] start = new int[stages];
            int[] end = new int[stages];

            for (int i = 0; i < stages;)
            {
                string input1 = Console.ReadLine();
                start[i] = Convert.ToInt32(input1.Split(' ')[0]);
                end[i] = Convert.ToInt32(input1.Split(' ')[1]);

                if (start[i] >= 0 && end[i] > start[i] && end[i] <= total_length)
                {
                    i++;
                }
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
