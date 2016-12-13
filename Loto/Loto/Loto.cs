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
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("0.00000000", Lottery(1));
            //Assert.AreEqual(0.00001845, Lottery(2));
            //Assert.AreEqual(0.00096862, Lottery(3));

        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("0.00000151", Lottery5of40(1));
        }
        string Lottery5of40(int category)
        {
            return (Combinations(5, 5) * Combinations(35, 0) / Combinations(40, 5)).ToString("N8");

        }
        string Lottery(int category)
        {
            if (category == 1)
                return (Combinations(6, 6) * Combinations(43, 0) / Combinations(49, 6)).ToString("N8");
            if (category ==2)
                return (Combinations(6, 5) * Combinations(43, 1) / Combinations(49, 6)).ToString("N8");
            return (Combinations(6, 4) * Combinations(43, 2) / Combinations(49, 6)).ToString("N8");

        }
        private static int Combinations(int n, int k)
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
