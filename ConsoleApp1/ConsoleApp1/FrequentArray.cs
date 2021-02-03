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
            List<int> CustomDictionary2 = new List<int>();

            foreach (int num in numArray)
            {
                CustomDictionary.Add(new Tuple<int, int>(num, numArray.Count(x => x == num)));
            }
             
            foreach (var pair in CustomDictionary)
            {
                Console.WriteLine("FOREACH VAR: {0}, {1}", pair.Item1, pair.Item2);
            }

            int maxAt = 0;
            
            for (int i = 0; i < CustomDictionary.Count; i++)
            {
                maxAt = CustomDictionary[i].Item2 > CustomDictionary[maxAt].Item2 ? i : maxAt;
            }

            Console.WriteLine("largest inpuit at " + maxAt);
            int Num = CustomDictionary[maxAt].Item1;
            int Freq = CustomDictionary[maxAt].Item2;


            for (int i = 0; i < CustomDictionary.Count; i++)
            {
                if(CustomDictionary[i].Item2 == Freq)
                    CustomDictionary2.Add(CustomDictionary[i].Item1);

            }


            foreach (var pair in CustomDictionary2)
            {
                Console.WriteLine("FOREACH VAR: {0} ", pair);
            }
            CustomDictionary2 = CustomDictionary2.Distinct().ToList();

            foreach (var pair in CustomDictionary2)
            {
                Console.WriteLine("----FOREACH VAR: {0} ", pair);
            }





        }
    }
}
