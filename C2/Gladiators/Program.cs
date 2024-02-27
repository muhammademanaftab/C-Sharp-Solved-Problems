using static Gladiators.Program;

namespace Gladiators
{
    internal class Program
    {
        public struct gladiators
        {
            public string name;
            public int time;
            public string century;
            public int total_bt;
            public int win_bt;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = Convert.ToInt32(input.Split(";")[0]);
            int won = Convert.ToInt32(input.Split(";")[1]);
            gladiators[] data = new gladiators[count];
            data = readData(data, count);

             /*for (int i = 0; i < data.Length; i++)
             {
                 Console.WriteLine(data[i].win_bt);
             }*/

            int task_A = taskA(data, count, won);
            string[] task_B = taskB(data , count) ;

            /*for (int i = 0; i < task_B.Length; i++) {

                Console.WriteLine(task_B[i]);
            }*/

            int  task_C = taskC(data, count);     
            string task_D = taskD(data, count);

        }

        public static gladiators[] readData(gladiators[] data, int count)
        {
            for (int i = 0; i < count; i++) 
            {
                string input = Console.ReadLine();
                data[i].name = input.Split(";")[0];
                data[i].time = Convert.ToInt32 (input.Split(";")[1]);
                data[i].century = input.Split(";")[2];
                data[i].total_bt = Convert.ToInt32( input.Split(";")[3]);
                data[i].win_bt = Convert.ToInt32(input.Split(";")[4]);
            }
            return data;
        }

        public static int taskA(gladiators[] data, int count, int won)
        {
            int max = 0;
            for (int i = 0;i < count; i++)
            {
                if (data[i].win_bt > won)
                {
                    max++;
                }
            }
            return max;
        }

        public static string[] taskB(gladiators[] data, int count)
        {
            int cnt = 0;
            for (int i=0; i < count; i++)
            {
                if ((data[i].century == "BC") && (data[i].total_bt > 14 ))
                {
                    cnt++;
                }
            }

            string[] result = new string[cnt];
            int k = 0;

            for (int i = 0; i < count; i++) 
            {
                if ((data[i].century == "BC") && (data[i].total_bt > 14))
                {
                    result[k] = data[i].name;
                    k++;
                }
                
            }

            if (k == 0)
            {
                result = new string[1];
                result[0] = "NONE";
                
            }

            return result;
        }

        public static string taskD(gladiators[] data, int count)
        {
            string result = "";

            double best = ((double)data[0].win_bt / data[0].total_bt);

            for (int i = 0; i < count; i++)
            {
                double ratio = ((double)data[i].win_bt / data[i].total_bt);
                if (ratio > best)
                {
                    best = ratio;
                }
            }

            for (int i = 0; i < count; i++)
            {
                double ratio = (double)data[i].win_bt / data[i].total_bt;
                if (ratio == best)
                {
                    result = data[i].name;
                    break; 
                }
            }

            return result;
        }

        public static int taskC(gladiators[] data, int count)
        {
            int[] sort_wb = new int[count];

            for (int i=0;i<count; i++)
            {
                sort_wb[i] = data[i].win_bt;
            }

            Array.Sort(sort_wb);
            Array.Reverse(sort_wb);
            int result = 0;

            for (int i=0; i < 3; i++)
            {
                result += sort_wb[i];
            }
            return result;
        }



    }

}