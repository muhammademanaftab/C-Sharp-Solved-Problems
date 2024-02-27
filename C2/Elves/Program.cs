namespace Elves_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Give the number of Elves and Gifts!");
            string input = Console.ReadLine();
            int Elves = Convert.ToInt32(input.Split(" ")[0]);
            int Gifts = Convert.ToInt32(input.Split(" ")[1]);

            string[] over_all = new string[Elves];
            for (int i = 0; i < Elves; i++)
            {
                over_all[i] = Console.ReadLine();
            }

            int[,] data_without_rep = read_data(Elves, over_all);

            int max_columns = maxCols(over_all, Elves);
            int A = taskA(data_without_rep, Elves, max_columns);
            int B = taskB(data_without_rep, Elves, max_columns);
            int Ca = taskCa(data_without_rep, Elves, max_columns, Gifts);
            int[] Cb = taskCb(data_without_rep, Elves, max_columns, Gifts, Ca);


           /* string output = $"{Ca}";
            for (int i=0; i<Ca; i++)
            {
                output = output + $" {Cb[i]}" ; 
            }
            Console.WriteLine(output);*/


        }

        public static int[,] read_data(int Elves, string[] over_all)
        {
            int max_Cols = maxCols(over_all, Elves);

            int[,] data = new int[Elves, max_Cols];
            for (int i = 0; i < Elves; i++)
            {
                string data_values = over_all[i];
                int first_value = Convert.ToInt32(data_values.Split(" ")[0]);

                for (int j = 0; j < first_value; j++)
                {
                    data[i, j] = Convert.ToInt32(data_values.Split(" ")[j + 1]);
                }
            }
            return data;
        }

        public static int maxCols(string[] over_all, int Elves)
        {
            int maxCols = 0;

            for (int i = 0; i < Elves; i++)
            {
                int count = Convert.ToInt32(over_all[i].Split(" ")[0]);

                if (maxCols < count)
                {
                    maxCols = count;
                }
            }
            return maxCols;
        }

        public static int taskA(int[,] data_without_rep, int Elves, int max_cols)
        {
            int equal_ten = 0;

            for (int i = 0; i < Elves; i++)
            {
                for (int j = 0; j < max_cols; j++)
                {
                    if (data_without_rep[i, j] == 10)
                    {
                        equal_ten += 1;
                    }
                }
            }

            return equal_ten;
        }

        public static int taskB(int[,] data_without_rep, int Elves, int max_cols)
        {
            int[] sum = new int[Elves];
            for (int i = 0; i < Elves; i++)
            {
                int temp = 0;
                for (int j = 0; j < max_cols; j++)
                {
                    temp = temp + data_without_rep[i, j];
                }
                sum[i] = temp;
            }
            int max_sum = sum[0];
            int max_index = 0;
            for (int i = 1; i < Elves; i++)
            {
                if (sum[i] > max_sum)
                {
                    max_sum = sum[i];
                    max_index = i;
                }
            }
            return (max_index + 1);
        }

        public static int taskCa(int[,] data_without_rep, int Elves, int max_cols, int Gifts)
        {
            int[] sum = new int[Elves];

            for (int i = 0; i < Elves; i++)
            {
                int temp = 0;
                for (int j = 0; j < max_cols; j++)
                {
                    temp = temp + data_without_rep[i, j];
                }
                sum[i] = temp;
            }

            int count = 0;
            for (int i = 0; i < Elves; i++)
            {
                if (sum[i] > Gifts)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] taskCb(int[,] data_without_rep, int Elves, int max_cols, int Gifts, int count)
        {
            int[] sum = new int[Elves];

            for (int i = 0; i < Elves; i++)
            {
                int temp = 0;
                for (int j = 0; j < max_cols; j++)
                {
                    temp = temp + data_without_rep[i, j];
                }
                sum[i] = temp;
            }

            int[] greater = new int[count];

            int c = 0;
            for (int i = 0; i < Elves; i++)
            {
                if (sum[i] > Gifts)
                {
                    greater[c++] = i + 1;

                }
            }
            return greater;

        }
    }
}
