using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void VerificationMultiple()
        {
            Assert.AreEqual("Fizz", CalculateMultiple(3));
            Assert.AreEqual("Buzz", CalculateMultiple(5));
            Assert.AreEqual("FizzBuzz", CalculateMultiple(15));
            Assert.AreEqual("nu exista", CalculateMultiple(8));
        }

        string CalculateMultiple(int multiple)
        {
            if (multiple % 15 == 0)
                return "FizzBuzz";
            if (multiple % 3 == 0)
                return "Fizz";
            if (multiple % 5 == 0)
                return "Buzz";
            return "nu exista";
        }
    }
}
