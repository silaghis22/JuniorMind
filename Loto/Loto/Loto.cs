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
            Assert.AreEqual(0.00000152, CalculateTheProbability(5,5,40));
            Assert.AreEqual(0.00000007, CalculateTheProbability(6,6,49));
            Assert.AreEqual(0.00001845, CalculateTheProbability(5,6,49));
            Assert.AreEqual(0.00096862, CalculateTheProbability(4,6,49));
        }
        double CalculateTheProbability(int guessedNumbers, int drawnNumbers, int of)
        {
            return Convert.ToDouble((Combinations(drawnNumbers, guessedNumbers) * Combinations(of - drawnNumbers, drawnNumbers - guessedNumbers) / Combinations(of, drawnNumbers)).ToString("N8"));
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
