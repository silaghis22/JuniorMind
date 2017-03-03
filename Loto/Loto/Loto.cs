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
            Assert.AreEqual(0.00000152, Lottery(5,40));
            Assert.AreEqual(0.00000007, Lottery(6,49));
            Assert.AreEqual(0.00001845, Lottery(5,49));
            Assert.AreEqual(0.00096862, Lottery(4,49));
        }
        double Lottery(int number,int of)
        {
            if (of == 40)
                switch (number)
                {
                    case 5:
                        return Convert.ToDouble((Combinations(5, 5) * Combinations(35, 0) / Combinations(40, 5)).ToString("N8"));
                    default:
                        return 0;
                }
            else
            {
                if (of == 49)
                {
                    switch (number)
                    {
                        case 4:
                            return Convert.ToDouble((Combinations(6, 4) * Combinations(43, 2) / Combinations(49, 6)).ToString("N8"));
                        case 5:
                            return Convert.ToDouble((Combinations(6, 5) * Combinations(43, 1) / Combinations(49, 6)).ToString("N8"));
                        case 6:
                            return Convert.ToDouble((Combinations(6, 6) * Combinations(43, 0) / Combinations(49, 6)).ToString("N8"));
                        default:
                            return 0;
                    }
                }
                return 0;
            }
               
        }

        private static double Combinations(long n, int k)
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
