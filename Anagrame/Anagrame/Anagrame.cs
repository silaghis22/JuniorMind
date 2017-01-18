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
            Assert.AreEqual(1, Repetition("abb"));
            Assert.AreEqual(3, Repetition("abbb"));
            Assert.AreEqual(4, Repetition("aabbb"));
            Assert.AreEqual(4, Repetition("babab"));
        }
        int Permutation (string word)
        {
            int repetition = Repetition(word);
            int number = 1;
            if(repetition == 0)
            {
                for (int i = 1; i <= word.Length; i++)
                    number *= i;
                return number;
            }

            if(repetition>word.Length-repetition)
            {
                for (int i = 1; i <= word.Length; i++)
                    number *= i;
                return number;

            }

        }
        private int Repetition (string word)
        {
            int repetition = 0 ;
            int length = word.Length;
            for (int i = 0; i < length - 1; i++)
                for (int j = i + 1; j < length; j++)
                    if (word[i] == word[j])
                        repetition++;
                        
            return repetition;
        }
    }
}
