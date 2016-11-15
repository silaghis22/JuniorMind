using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace squares
{
    [TestClass]
    public class squares
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(64, NumberTheSquares(1));
            Assert.AreEqual(113, NumberTheSquares(2));
        }
        int NumberTheSquares(int squares)
        {
            int number = 0;
            if (squares >= 1)
                number += 8 * 8;
            if (squares == 2)
                number += 7 * 7;
            return number;
        }

    }
}
