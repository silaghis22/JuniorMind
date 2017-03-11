using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OperatiiPeBiti
{
    [TestClass]
    public class OperatiiPeBiti
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Assert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1 }, ConversionFromDecimalInBaseTwo(49));
            Assert.AreEqual("110001",ConversionFromDecimalInBaseTwo(49));
        }
        /*byte[] ConversionFromDecimalInBaseTwo (int number)
        {
            byte[] array = new byte [32];
            int i = 0;
            while (number>0)
            {

                for (int j = i; j > 0; j--)
                    array[j] = array[j - 1];
                array[i] =(byte)(number % 2);
                number /= 2;
                i++; 
                      
            }

            return array;
        }*/
        string ConversionFromDecimalInBaseTwo(int number)
        {
            string array=String.Empty;
            while (number>0)
            {
                array = Convert.ToString(number % 2)+ array;
                number /= 2;
            }
            return array;
        }
    }
}
