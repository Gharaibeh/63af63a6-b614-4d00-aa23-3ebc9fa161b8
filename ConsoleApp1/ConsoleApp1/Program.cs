using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FrequentArray freq = new FrequentArray();

            int[] arr = new int[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 };
            //int[] arr = new int[] { 1, 4, 6, 7};
            freq.findLongest(arr);
            Console.ReadLine();

        }
    }
}
