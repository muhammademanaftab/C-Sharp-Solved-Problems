namespace Elves_new
{
    internal class Program
    {
        public struct elf
        {
            public int R;
            public List<int> G;
        }

        static void Main(string[] args)
        {
            //Input
            string[] input = Console.ReadLine().Split(" ");
            int N = Convert.ToInt32(input[0]);
            int K = Convert.ToInt32(input[1]);
            elf[] elves = inputData(N);

            ////Task A
            //int count = taskA(elves);
            //Console.WriteLine(count);

            //Task D
            bool yesOrNo = taskD(elves);
            if (yesOrNo)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        public static elf[] inputData(int N)
        {
            elf[] elves = new elf[N];

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                elves[i].R = Convert.ToInt32(input[0]);
                elves[i].G = new List<int>();

                for (int j = 0; j < elves[i].R; j++)
                    elves[i].G.Add( Convert.ToInt32(input[j+1]) );
            }

            return elves;
        }

        public static int taskA(elf[] elves)
        {
            int count = 0;

            for (int i = 0; i < elves.Length; i++)
            {
                for (int j = 0; j < elves[i].R; j++)
                    if (elves[i].G[j] == 10)
                        count++;
            }

            return count;
        }

        public static bool taskD(elf[] elves)
        {
            bool exists = false;

            //Array of sum of all rucksacks for each elf
            int[] sumArray = new int[elves.Length];
            for (int i = 0; i < sumArray.Length; i++)
            {
                
                sumArray[i] = 0;
                for (int j = 0; j < elves[i].R; j++)
                {
                    sumArray[i] += elves[i].G[j];
                }
            }

            //Minimum gift for each elf
            int[] minArray = new int[elves.Length];
            for (int i = 0; i < elves.Length; i++)
            {
                int minIndex = 0;
                for (int j = 0; j < elves[i].R; j++)
                {
                    if (elves[i].G[j] < elves[i].G[minIndex])
                        minIndex = j;
                }
                minArray[i] = elves[i].G[minIndex];
            }

            for (int i = 0; i < elves.Length; i++)
            {
                for (int j = 0; j < elves.Length; j++)
                {
                    if (i != j && sumArray[i] < minArray[j])
                    {
                        exists = true;
                        return exists;
                    }
                }
            }


            return exists;
        }
    }
}