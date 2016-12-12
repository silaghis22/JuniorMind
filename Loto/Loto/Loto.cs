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
            Assert.AreEqual(6, Combinations(6, 5));
            Assert.AreEqual(0.0000000, Lottery(1));
            Assert.AreEqual(0.0000000, Lottery(2));
            Assert.AreEqual(0, Lottery(3));
        }
        float Lottery(int category)
        {
            if(category ==1)
                return (float)(Combinations(6, 6) * Combinations(43, 0) / Combinations(49, 6));
            if(category ==2)
                return (float)((Combinations(6, 5) * Combinations(43, 1) / Combinations(49, 6)));
            return (float)(Combinations(6, 4) * Combinations(43, 2) / Combinations(49, 6));

        }
        static int Combinations(int n,int k)
        {
            if (k == 0)
                return 1;
            else
            if (k > n)
                return 0;
            else
                return (Combinations(n - 1, k) + Combinations(n - 1, k - 1));
        }
    }
}
