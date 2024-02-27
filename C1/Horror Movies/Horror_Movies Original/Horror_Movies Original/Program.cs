namespace C1_Task1_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the number of lines, the start limit, and the end limit!");
            int dataLength = 0;
            int limitYear = 0;
            double limitRating = 0.0;

            //first line input error checking
            do
            {
                Console.WriteLine("Give the dataLength limitYear and limitRating:");
                string input = Console.ReadLine();
                dataLength = Convert.ToInt32(input.Split(' ')[0]);
                limitYear = Convert.ToInt32(input.Split(' ')[1]);
                limitRating = Convert.ToDouble(input.Split(' ')[2]);
            } while (!(dataLength >= 1 && dataLength <= 50 && limitYear >= 1932 && limitYear <= 2022 && limitRating >= 0 && limitRating <= 10));

            int[] year = new int[dataLength];
            double[] rating = new double[dataLength];
            string[] title = new string[dataLength];

            //read data to array with error checking
            for (int i = 0; i < dataLength;)
            {
                Console.WriteLine("Give the proper data for the next film:");
                string input = Console.ReadLine();
                year[i] = Convert.ToInt32(input.Split(';')[0]);
                rating[i] = Convert.ToDouble(input.Split(';')[1]);
                title[i] = input.Split(';')[2];
                if (year[i] >= 1932 && year[i] <= 2022 && rating[i] >= 0 && rating[i] <= 10 && title[i].Length >= 1 && title[i].Length <= 50)
                    i++;
            }

            //TaskA a)
            double maxRatedVal = 0;
            int maxRatedInd = 0;
            for (int i = 0; i < dataLength; i++)
            {
                if (limitYear == year[i])
                {
                    if (rating[i] > maxRatedVal)
                    {
                        maxRatedVal = rating[i];
                        maxRatedInd = i;
                    }
                }
            }
            string filmTitleForMaxVal = title[maxRatedInd];
            Console.WriteLine("#1\n" + filmTitleForMaxVal);

            //TaskA b)
            string filmTitleAll = "";
            for (int i = 0; i < dataLength; i++)
            {
                if (limitRating == rating[i])
                    filmTitleAll += title[i] + "\n";
            }
            Console.WriteLine("#2\n" + filmTitleAll);
        }
    }
}