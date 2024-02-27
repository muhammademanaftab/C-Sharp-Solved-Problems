namespace ShoppingTea

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                count = Convert.ToInt32(Console.ReadLine());

                if (!(count >= 1 && count <= 100))
                {
                    Console.WriteLine("Count of Tea Should Be Greater Than Equal 1 And Less than Equal 100");
                }

            } while (!(count >= 1 && count <= 100));

            string[] Tea = new string[count];
            int[] Prices = new int[count];

            for (int i = 0; i < count;)
            {
                Tea[i] = Console.ReadLine();
                Prices[i] = Convert.ToInt32((Console.ReadLine()));

                if (Tea[i].Length <= 20 && !(Tea[i].Contains(' ')) && Prices[i] <= 2000 && Prices[i] >= 1)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("The Name of Tea Shouldnot Contain more than 20 characters and prices of tea should not exceed 2000");
                }

            }
            int max_price = Prices[0];
            int index_max = 0;

            for (int i = 0; i < count; i++)
            {
                if (max_price < Prices[i])
                {
                    max_price = Prices[i];
                    index_max = i + 1;
                }
            }

            Console.WriteLine(index_max);
            Console.ReadLine();
        }
    }
}