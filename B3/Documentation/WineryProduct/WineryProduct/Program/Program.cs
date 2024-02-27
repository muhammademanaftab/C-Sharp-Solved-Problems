using System;

namespace B_3
{
    internal class Program
    {
        public struct wine
        {
            public string name;
            public string type;
            public int amount;
            public int price;
        }

        public struct Output
        {
            public string name;
            public string type;
            public int amount;
        }

        static void Main(string[] args)
        {
            bool good;
            int N;
            do
            {
                Console.Write("Number of Wineries:");
                string n_winery = Console.ReadLine();
                good = int.TryParse(n_winery, out N) && N >= 1 && N <= 100;
                if (!good)
                {

                    Console.WriteLine("Wrong Number of Wineries, it must be in the range of 1-100, Enter Again.");
                }
            }

            while (!(good));


            wine[] wines = new wine[N];
            wines = read_arrange(wines, N);
            Output result = findMaximum(wines, N);
            Console.WriteLine("==========Output==========");
            Console.WriteLine($"{result.name} {result.type} {result.amount}");
            //string output = result.name + " " + result.type + " " + result.amount;
            Console.ReadLine();


        }

        public static bool alreadyAMember(string input, wine[] wines, int cnt)
        {
            int i = 0;
            string name = input.Split(";")[0];
            string type = input.Split(";")[1];
            while (i < cnt && !(wines[i].name == name && wines[i].type == type) )
            {
                i = i + 1;
            }
            bool exists = i < cnt;

            return exists;
        }

        public static Output findMaximum(wine[] wines, int cnt)
        {
            Output max_result;
            max_result.name = wines[0].name;
            max_result.amount = wines[0].amount;
            max_result.type = wines[0].type;

            int maxPrice = wines[0].price;

            for (int i = 0; i < cnt; i++)
            {
                if (wines[i].price > maxPrice)
                {
                    max_result.name = wines[i].name;
                    max_result.amount = wines[i].amount;
                    max_result.type = wines[i].type;
                    maxPrice = wines[i].price;
                }
            }
            return max_result;
        }

        public static wine[] read_arrange(wine[] wines, int N)
        {
            Console.WriteLine("==========Input==========");
            int cnt = 0;
          
            for (int i = 0; i < N; i++)
            {

                string input;
                bool good;

                do
                {
                    Console.WriteLine("Enter the Name, Product, Amount, and Price of Winery {0}:",i+1);
                    input = Console.ReadLine();
                    string[] inputValues = input.Split(';');

                    int amount, price = 0; 

                    good = int.TryParse(inputValues[2], out amount) && amount >= 1 && amount <= 10000 &&
                           int.TryParse(inputValues[3], out price) && price >= 1 && price <= 10000;

                    if (!good)
                    {
                        Console.WriteLine("Amount and Price of winery must be in the range of 1-10000. Please enter data again.");
                    }
                    else
                    {
                        wines[i].amount = amount;
                        wines[i].price = price;
                    }
                }
                while (!good);




                if (alreadyAMember(input, wines, cnt))
                {
                    for (int j = 0; j < cnt; j++)
                    {
                        if (wines[j].name == input.Split(";")[0] && wines[j].type == input.Split(";")[1])
                        {
                            int amount = Convert.ToInt32(input.Split(";")[2]);
                            int price = Convert.ToInt32(input.Split(";")[3]);
                            wines[j].amount += amount;
                            wines[j].price += price;
                        }
                    }
                }
                else
                {
                    wines[cnt].name = input.Split(";")[0];
                    wines[cnt].type = input.Split(";")[1];
                    wines[cnt].amount = Convert.ToInt32(input.Split(";")[2]);
                    wines[cnt].price = Convert.ToInt32(input.Split(";")[3]);
                    cnt++;
                }
            }
            return wines;
            
        }

    }
}
