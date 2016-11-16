using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class Prefix
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("a", SearchPrefix("abcd", "acd"));
            Assert.AreEqual("", SearchPrefix("acv", "cds"));
            Assert.AreEqual("aabcd", SearchPrefix("aabcd", "aabcdrstv"));
        }
        string SearchPrefix(string word,string _word)
        {
            int i;
            for ( i = 0; i < word.Length; i++)
                if (word[i] != _word[i])
                    break;
            return word.Substring(0, i);
            //return '1';
        }
    }
}
