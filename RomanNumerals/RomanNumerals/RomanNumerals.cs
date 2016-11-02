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
        string CreateRomanNumerals(int number)
        {
            string romanNumerals=string.Empty;
            int unit = number % 10;
            int dozens = number / 10;
            switch (dozens)
            {
                case 10:
                    romanNumerals += "C";
                    break;
                case 9:
                    romanNumerals += "XC";
                    break;
                case 8:
                    romanNumerals += "LXXX";
                    break;
                case 7:
                    romanNumerals += "LXX";
                    break;
                case 6:
                    romanNumerals += "LX";
                    break;
                case 5:
                    romanNumerals += "L";
                    break;
                case 4:
                    romanNumerals += "XL";
                    break;
                case 3:
                    romanNumerals += "XXX";
                    break;
                case 2:
                    romanNumerals += "XX";
                    break;
                case 1:
                    romanNumerals += "X";
                    break;


            }
            switch (unit)
            {
                case 9:
                    romanNumerals += "IX";
                    break;
                case 8:
                    romanNumerals += "VIII";
                    break;
                case 7:
                    romanNumerals += "VII";
                    break;
                case 6:
                    romanNumerals += "VI";
                    break;
                case 5:
                    romanNumerals += "V";
                    break;
                case 4:
                    romanNumerals += "IV";
                    break;
                case 3:
                    romanNumerals += "III";
                    break;
                case 2:
                    romanNumerals += "II";
                    break;
                case 1:
                    romanNumerals += "I";
                    break;
            }
            return romanNumerals;

        }

    }
}
