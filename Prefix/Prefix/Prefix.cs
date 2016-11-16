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
            Assert.AreEqual('a', SearchPrefix("abcd", "acd"));
            Assert.AreEqual('1', SearchPrefix("acv", "cds"));
        }
        char SearchPrefix(string word,string _word)
        {
            if(word[0]==_word[0])
                return word[0];
            return '1';
        }
    }
}
