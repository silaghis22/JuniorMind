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
            Assert.AreEqual(203, NumberTheSquares(7));
            Assert.AreEqual(204, NumberTheSquares(8));


        }
        int NumberTheSquares(int squares)
        {
            int number = 0;
            int i = 8;
            while(squares>0)
            {
                number += i * i;
                i--;
                squares--;
            }
            return number;
        }

    }
}
