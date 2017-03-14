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
            CollectionAssert.AreEqual(new byte[] { 1, 0, 0, 0, 1, 1 },ConversionFromDecimalInRandomBase(49,2));
            Assert.AreEqual(49, ConversionFromRandomBaseInDecimal(new byte[] { 1, 0, 0, 0, 1, 1 }, 2));
            Assert.AreEqual(1, ShiftRight(new byte[] {0,0,0,1 }, 2, 3));
            Assert.AreEqual(20, ShiftLeft(new byte[] { 1, 0, 1 }, 2, 2));
        }
        byte[] ConversionFromDecimalInRandomBase (int number , int randomBase)
        {
            int length = CalculatePower(number, randomBase);
            byte[] array =new byte [length] ;
            int i = 0;
            while (number>0)
            {
                array[i] =(byte)(number % randomBase);
                number /= randomBase;
                i++; 
                      
            }

            return array;
        }
        int CalculatePower(int number , int randomBase)
        {
            int pow = 0;
            while (number > Math.Pow(randomBase, pow))
                pow++;
            return pow;
        }
        int ConversionFromRandomBaseInDecimal(byte[] array , int randomBase)
        {
            int number = 0;
            for (int i = 0; i < array.Length; i++)
                number +=array[i]*(int)( Math.Pow(randomBase, i)); 
            return number;
        }
        int ShiftRight(byte[] array, int randomBase, int numberOfPositions)
        {
            int number = ConversionFromRandomBaseInDecimal(array, randomBase);
            for (int i = 1; i <= numberOfPositions; i++)
                number /= randomBase;
            return number;
        }
        int ShiftLeft(byte[] array, int randomBase, int numberOfPositions)
        {
            int number = ConversionFromRandomBaseInDecimal(array, randomBase);
            for (int i = 1; i <= numberOfPositions; i++)
                number *= randomBase;
            return number;
        }

    }
}
