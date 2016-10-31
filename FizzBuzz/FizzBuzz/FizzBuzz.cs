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
            Assert.AreEqual("Fizz", CalculateMultiple(3, "Fizz", "Buzz"));
            Assert.AreEqual("Buzz", CalculateMultiple(5, "Fizz", "Buzz"));
            Assert.AreEqual("FizzBuzz", CalculateMultiple(15, "Fizz", "Buzz"));
            Assert.AreEqual("nu exista", CalculateMultiple(8, "Fizz", "Buzz"));
        }

        string CalculateMultiple(int multiple, string wordThree, string wordFive)
        {
            
            if (multiple % 3 == 0)
            {

                if (multiple % 5 == 0)
                    return wordThree + wordFive;
                else
                    return wordThree;

            }
            else
                if (multiple % 5 == 0)
                    return wordFive;

            return "nu exista";

        }



    }
}
