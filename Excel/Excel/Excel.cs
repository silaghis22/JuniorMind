using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excel
{
    [TestClass]
    public class Excel
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual('A', TheColumn(1));
            Assert.AreEqual('Z', TheColumn(26));
        }
        char TheColumn(int nrColumn)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return alphabet[nrColumn - 1]; 
        }
    }
}
