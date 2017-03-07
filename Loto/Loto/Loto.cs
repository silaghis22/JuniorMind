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
            int numberHelp = NumberHlep(of) ;

            return Convert.ToDouble((Combinations(numberHelp, number) * Combinations(of-numberHelp, numberHelp - number) / Combinations(of, numberHelp)).ToString("N8"));
        }
        private int NumberHlep (int of)
        {
            if (of == 40)
                return 5;
            else return  6;
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
