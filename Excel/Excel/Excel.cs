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
            Assert.AreEqual("A", TheColumn(1));
            Assert.AreEqual("Z", TheColumn(26));
            Assert.AreEqual("AA", TheColumn(27));
            Assert.AreEqual("BA", TheColumn(53));
            Assert.AreEqual("AZ", TheColumn(52));
            Assert.AreEqual("ZA", TheColumn(677));
            Assert.AreEqual("ZZ", TheColumn(702));
            Assert.AreEqual("AAA", TheColumn(703));
            Assert.AreEqual("ABA", TheColumn(729));
            Assert.AreEqual("ABC", TheColumn(731));
            Assert.AreEqual("AZA", TheColumn(1353));
            Assert.AreEqual("AZZ", TheColumn(1378));
            Assert.AreEqual("ZZZ", TheColumn(18278));
            Assert.AreEqual("AAAA", TheColumn(18279));
            Assert.AreEqual("AAAZ", TheColumn(18304));


        }


        string TheColumn(int column)
        {
            string columnName = string.Empty;
            //string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            while (column>0)
            {
                column--;
                columnName = Convert.ToString((char)('A' + column % 26)) + columnName;
                column /= 26;

            }
            return columnName;
        }

    }
}
