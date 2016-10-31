using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class RomanNumerals
    {
        
        [TestMethod]
        public void VerificationRomanNumerals()
        {
             Assert.AreEqual("C", CreateRomanNumerals(100));
             Assert.AreEqual("XLIX", CreateRomanNumerals(49));
             Assert.AreEqual("XCIX", CreateRomanNumerals(99));
             Assert.AreEqual("LXX", CreateRomanNumerals(70));
             Assert.AreEqual("XXII", CreateRomanNumerals(22));
             Assert.AreEqual("LXXXIX", CreateRomanNumerals(89));
             Assert.AreEqual("I", CreateRomanNumerals(1));


        }
        string CreateRomanNumerals(int nr)
        {
            string romanNumerals=string.Empty;
            int number = nr;
            for(int i=0;i<=number;i++)
            {
                
                if (number >= 100)
                {
                    romanNumerals += "C";
                    number -= 100;
                }
                if (number >= 90)
                {
                    romanNumerals += "XC";
                    number -= 90;
                }

                if (number >= 50 && number < 90)
                {
                    romanNumerals += "L";
                    number -= 50;
                }
                if (number >= 40)
                {
                    romanNumerals += "XL";
                    number -= 40;
                }
                while (number >= 10 && number < 40)
                {
                    romanNumerals += "X";
                    number -= 10;
                }
                if (number >= 9)
                {
                    romanNumerals += "IX";
                    number -= 9;
                }
                while (number >= 5 && number <= 8)
                {
                    romanNumerals += "V";
                    number -= 5;
                }
                if (number == 4)
                {
                    romanNumerals += "IV";
                    number -= 4;
                }
                while (number > 0 && number < 4)
                {
                    romanNumerals += "I";
                    number -= 1;
                }
            }
            return romanNumerals;
        }

    }
}
