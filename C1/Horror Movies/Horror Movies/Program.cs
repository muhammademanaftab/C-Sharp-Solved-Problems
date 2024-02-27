using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horror_Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int dataLength= Convert.ToInt32(input.Split(' ')[0]);
            int limitYear= Convert.ToInt32(input.Split(' ')[1]);
            double limitRating= Convert.ToDouble(input.Split(' ')[2]);

            int[] year = new int[dataLength];
            double[] rating = new double[dataLength];
            string[] title = new string[dataLength];


            for (int i = 0; i < dataLength; i++) { 
            string input_data= Console.ReadLine();
            year [i]= Convert.ToInt32(input_data.Split(';')[0]);
            rating[i]= Convert.ToDouble(input_data.Split(';')[1]);
            title [i] =(input_data.Split(';')[2]);
            }

            double maxRatedVal = 0;
            int maxRatedInd = 0;

            for (int i=0; i < dataLength; i++)

            {
                if (limitYear == year[i])
                {
                    

                if (rating[i] > maxRatedVal )
                {
                    maxRatedVal = rating [i];
                    maxRatedInd = i;
                }

                }
            }
            Console.WriteLine("#1: ");
            string filmTitleForMaxVal = title[maxRatedInd];
            Console.WriteLine(filmTitleForMaxVal);

            string filmTitleAll = "";
            for (int i = 0; i < dataLength; i++)
            {

                if (rating[i] == limitRating)
                {
                    filmTitleAll = filmTitleAll + title[i] + '\n';
                }
            }
            Console.WriteLine("#2");
            Console.WriteLine(filmTitleAll);
            Console.ReadLine();
        }
    }
}
