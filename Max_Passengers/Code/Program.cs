namespace B_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count_stations = Convert.ToInt32(Console.ReadLine());
            int[] getin = new int[count_stations];
            int[] getout = new int[count_stations];

            for (int i = 0; i < count_stations; i++)
            {
                string input = Console.ReadLine();
                getin[i]= Convert.ToInt32(input.Split(' ')[0]);
                getout[i]= Convert.ToInt32(input.Split(' ')[1]);
            }
            int Max_passengers = getin[1] - getout[1];
            int geton = 0;
             for (int i =0; i < count_stations; i++) {
                geton = (geton + getin[i]) - getout[i];

                if (Max_passengers <=geton)
                {
                    Max_passengers = geton;
                }               
            
            }
            Console.WriteLine(Max_passengers);
            
        }
    }
}