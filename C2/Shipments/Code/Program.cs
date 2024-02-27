namespace Retake_C2
{
    internal class Program
    {
        public struct shipment
        {
            public int date;
            public string Identifier;
            public int Db;
        }
        static void Main(string[] args)
        {
            int N;
            string Identifier;
            string[] input = Console.ReadLine().Split(" ");
            N = Convert.ToInt32(input[0]);
            Identifier = input[1];


            shipment[] shipments = new shipment[N];
            for (int i = 0; i < N; i++)
            {
                string[] input2 = Console.ReadLine().Split(" ");
                shipments[i].date = Convert.ToInt32(input2[0]);
                shipments[i].Identifier = input2[1];
                shipments[i].Db = Convert.ToInt32(input2[2]);
            }

            //A
            //int good = TaskA(shipments);
            //Console.WriteLine(good);

            //B
            //string output = TaskB(shipments);
            //Console.WriteLine(output);

            //C
            //int cnt = TaskC(shipments);
            //Console.WriteLine(cnt);

            //D
            int count = TaskD(shipments, Identifier);
            Console.WriteLine(count);

        }

        public static int TaskA(shipment[] shipments)
        {
            int cnt = 0;
            for (int i = 0; i < shipments.Length; i++)
            {
                cnt += shipments[i].Db;
            }

            return cnt;
        }

        public static bool isMember(string inputStr, string[] listOfstr)
        {
            for (int i = 0; i < listOfstr.Length; i++)
            {
                if (listOfstr[i] == inputStr)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool isMemberInt(int input, int[] listOfInt)
        {
            for (int i = 0; i < listOfInt.Length; i++)
            {
                if (listOfInt[i] == input)
                {
                    return true;
                }
            }

            return false;
        }

        public static string TaskB(shipment[] shipments)
        {
            int cnt = 0;
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].date > 20)
                {
                    cnt++;
                }
            }

            if (cnt == 0)
                return "#";

            shipment[] filtered = new shipment[cnt];
            int j = 0;
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].date > 20)
                    filtered[j++] = shipments[i];

            }

            int[] arr = new int[cnt];

            for (int i = 0; i < filtered.Length; i++)
            {
                arr[i] = filtered[i].Db;
            }

            int maxInd = 0;
            for (int i = 0; i < cnt; i++)
            {
                if (arr[maxInd] < arr[i])
                {
                    maxInd = i;
                }
            }

            return filtered[maxInd].Identifier;
        }

        public static int TaskC(shipment[] shipments)
        {
            int cnt = 0;
            string[] ids = new string[shipments.Length];
            for (int i = 0; i < shipments.Length; i++)
            {
                if (!isMember(shipments[i].Identifier, ids))
                {
                    ids[cnt] = shipments[i].Identifier;
                    cnt++;
                }
            }

            return cnt;
        }

        public static int TaskD(shipment[] shipments, string inputID)
        {
            int cnt = 0;
            int[] days = new int[shipments.Length];
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].Identifier == inputID && !isMemberInt(shipments[i].date, days))
                {
                    days[cnt] = shipments[i].date;
                    cnt++;
                }
            }

            return cnt;
        }
    }
}