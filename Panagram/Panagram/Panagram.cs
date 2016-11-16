using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class Panagram
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(false, CheckPanagram( "asdfgv asdas"));
            Assert.AreEqual(true, CheckPanagram("qw er ty ui op asdfghjkl zxcvb nm"));
            Assert.AreEqual(true, CheckPanagram("the quick brown fox jumps over the lazy dog"));
        }
        bool CheckPanagram(string phrase)
        {
            string alphabet =  "qwertyuiopasdfghjklzxcvbnm " ;
            for (int i = 0; i < alphabet.Length; i++)
                if (-1 == phrase.IndexOf(alphabet[i]))
                    return false;
            return true;
        }
    }
}
