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


        string TheColumn(int nrColumn)
        {
            string nameColumn= string.Empty;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (nrColumn < 27)
                nameColumn = alphabet[nrColumn - 1] + nameColumn;
            else
                while (nrColumn>0)
                {
                    if (nrColumn % 26 == 0)
                        nameColumn = alphabet[25] + nameColumn;
                    else
                        nameColumn = alphabet[nrColumn % 26 - 1] + nameColumn;
                    if(nameColumn[0]== 'Z')
                        nrColumn = (nrColumn / 26)-1;
                    else
                        nrColumn = (nrColumn / 26);

                }
            return nameColumn;
        }

    }
}
