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
            Assert.AreEqual(1, Combinations(35, 0));
            Assert.AreEqual(658008, Combinations(40, 5));
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Assert.AreEqual("0.00000007", Lottery6Of49(1));
            //Assert.AreEqual("0.00001845", Lottery6Of49(2));
            //Assert.AreEqual("0.00096862", Lottery6Of49(3));

        }
        [TestMethod]
        public void TestMethod3()
        {
            //Assert.AreEqual(0.00000151, Lottery5of40(1));
        }
        string Lottery5of40(int category)
        {
            return  (Combinations(5, 5) * Combinations(35, 0) / Combinations(40, 5)).ToString("N8");

        }
        string Lottery6Of49(int category)
        {
            if (category == 1)
                return String.Format("{0:0.00000000}", (Combinations(6, 6) * Combinations(43, 0) / Combinations(49, 6)));
            if (category ==2)
                return String.Format("{0:0.00000000}", (Combinations(6, 5) * Combinations(43, 1) / Combinations(49, 6)));
            return String.Format("{0:0.00000000}", (Combinations(6, 4) * Combinations(43, 2) / Combinations(49, 6)));

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
