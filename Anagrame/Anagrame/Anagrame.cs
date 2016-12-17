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
            Assert.AreEqual(2, Permutation( "ab"));
            Assert.AreEqual(24, Permutation("sami"));
            Assert.AreEqual(3, Permutation("abb"));
            Assert.AreEqual(4, Permutation("abbb"));
        }
        int Permutation (string word)
        {
            int repetition = 0;
            for (int i = 0; i < word.Length; i++)
                for (int j = i + 1; j < word.Length; j++)
                    if (word[i] == word[j])
                        repetition++;
            int number = 1;
            for (int i = 1; i <= word.Length-repetition; i++)
                number *= i;
            return number+repetition;
        }
    }
}
