using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FrequentArray
    {
        public void findLongest(int[] numArray)
        {
            List<Tuple<int, int>> CustomDictionary = new List<Tuple<int, int>>();

            foreach (int num in numArray)
            {
                CustomDictionary.Add(new Tuple<int, int>(num, numArray.Count(x => x == num)));
            }
             
            foreach (var pair in CustomDictionary)
            {
                Console.WriteLine("FOREACH VAR: {0}, {1}", pair.Item1, pair.Item2);
            }
        }
    }
}
