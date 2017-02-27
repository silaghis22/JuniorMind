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
            Assert.AreEqual(4, Permutation("abbb"));
            Assert.AreEqual(5, Permutation("aabbb"));
            Assert.AreEqual(12, Permutation("babc"));
        }
        int Permutation (string word)
        {
            int repetition =word.Length- Repetition(word);
            return Factorial(word.Length) / Factorial(repetition + 1);
        }
        int Factorial (int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
                factorial *= i;
            return factorial;
        }
        int Repetition (string word)
        {
            string help=String.Empty;
            int lengthWord = word.Length;
            bool bol;
            for (int i = 0; i < lengthWord; i++)
            {
                bol = true;
                int lengthHelp = help.Length;

                for (int j = 0; j < lengthHelp; j++)
                {
                    if (word[i] == help[j])
                    {
                        bol = false;
                    }
                }
                if (bol==true)
                    help += word[i];

            }        
            return help.Length;
        }
    }
}
