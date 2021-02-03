using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            FrequentArray freq = new FrequentArray();
            int[] result = freq.findCommonArray(new int[] { 1, 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 });
            CollectionAssert.AreEquivalent(result, new int[] { 1, 5 ,4});

        }

        [TestMethod]
        public void TestMethod02()
        {
            FrequentArray freq = new FrequentArray();
            int[] result = freq.findCommonArray(new int[] { 1, 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 });
            CollectionAssert.AreEquivalent(result, new int[] { 5, 1, 4 });

        }


        [TestMethod]
        public void TestMethod03()
        {
            FrequentArray freq = new FrequentArray();
            int[] result = freq.findCommonArray(new int[] { 1, 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 });
            CollectionAssert.AreEquivalent(result, new int[] { 4 , 1 , 5 });

        }

        [TestMethod]
        public void TestMethod03()
        {
            FrequentArray freq = new FrequentArray();
            int[] result = freq.findCommonArray(new int[] { 1, 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 });
            CollectionAssert.AreEquivalent(result, new int[] { 4, 1, 5 });

        }
    }
}
