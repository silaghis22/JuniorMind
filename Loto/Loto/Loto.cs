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
            Assert.AreEqual(0.0000000, Lottery(1));
        }
        float Lottery(int category)
        {
            return (float)(Combinations(6, 6) * Combinations(43, 0) / Combinations(49, 6));
        }
        static int Combinations(int n,int k)
        {
            if ((n == k) || (k == 0))
                return 1;
            else
                return (Combinations(n, k - 1) + Combinations(n - 1, k - 1));
        }
    }
}
