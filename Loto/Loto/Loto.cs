using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto
{
    [TestClass]
    public class Loto
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Combinations(2, 2));
        }
        //decimal Lottery(int category)
        static int Combinations(int n,int k)
        {
            if ((n == k) || (k == 0))
                return 1;
            else
                return (Combinations(n, k - 1) + Combinations(n - 1, k - 1));
        }
    }
}
