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
            Assert.AreEqual(149, NumberTheSquares(3));
            Assert.AreEqual(174, NumberTheSquares(4));
            Assert.AreEqual(190, NumberTheSquares(5));
            Assert.AreEqual(199, NumberTheSquares(6));


        }
        int NumberTheSquares(int squares)
        {
            int number = 0;
            if (squares >= 1)
                number += 8 * 8;
            if (squares >= 2)
                number += 7 * 7;
            if (squares >= 3)
                number += 6 * 6;
            if (squares >= 4)
                number += 5 * 5;
            if (squares >= 5)
                number += 4 * 4;
            if (squares >= 6)
                number += 3 * 3;
            return number;
        }

    }
}
