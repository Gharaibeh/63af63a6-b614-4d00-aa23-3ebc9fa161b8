using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FrequentArray
    {
        List<int> filteredResults;
        List<Tuple<int, int>> CustomDictionary;

        public FrequentArray()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            CustomDictionary = new List<Tuple<int, int>>();
            filteredResults = new List<int>();
        }
        public int[] findCommonArray(int[] numArray)
        {
            findFrequencies(numArray);
            collectingMostFrequentNumbers(findLargestIndex());

            return filteredResults.ToArray();
        }

        private void findFrequencies(int[] numArray)
        {
            if (numArray.Length == 0)
            {
                throw new Exception("Input array is Zero!");
            }

            foreach (int num in numArray)
            {
                CustomDictionary.Add(new Tuple<int, int>(num, numArray.Count(x => x == num)));
            }
        }

        private int findLargestIndex()
        {
            int maxAt = 0;
            for (int i = 0; i < CustomDictionary.Count; i++)
            {
                maxAt = CustomDictionary[i].Item2 > CustomDictionary[maxAt].Item2 ? i : maxAt;
            }
            return maxAt;
        }


        private void collectingMostFrequentNumbers(int maxAt)
        {
            for (int i = 0; i < CustomDictionary.Count; i++)
            {
                if (CustomDictionary[i].Item2 == CustomDictionary[maxAt].Item2)
                    filteredResults.Add(CustomDictionary[i].Item1);
            }
            //removing duplicates
            filteredResults = filteredResults.Distinct().ToList();

        }
    }
}
