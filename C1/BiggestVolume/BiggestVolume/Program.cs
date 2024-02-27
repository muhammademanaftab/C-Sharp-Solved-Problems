using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_Volume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count_cubes= Convert.ToInt32(Console.ReadLine());
            int[] cubes= new int[count_cubes];
            for (int i=0 ; i<count_cubes; i++) { 
            cubes[i]= Convert.ToInt32(Console.ReadLine());
            }
            int volume = 0;
            for (int i=0 ; i<count_cubes; i++) { 
                volume = volume + (cubes[i] * cubes[i] * cubes[i]);
            }
            Console.WriteLine(volume);
            Console.ReadLine();
        }
    }
}
