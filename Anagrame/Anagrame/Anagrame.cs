using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrame
{
    [TestClass]
    public class Anagrame
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, Permutation("ab"));
            Assert.AreEqual(24, Permutation("sami"));
        }
        int Permutation (string word)
        {
            int number = 1;
            for (int i = 1; i <= word.Length; i++)
                number *= i;
            return number;
        }
    }
}
