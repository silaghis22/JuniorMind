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
            string romanNumerals = string.Empty;
            int unit = number % 10;
            int dozens = number / 10;
            string[] arrayDozens = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C" };
            string[] arrayUnit = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            if (dozens > 0)
                romanNumerals += arrayDozens[dozens - 1];
            if (unit > 0)
                romanNumerals += arrayUnit[unit - 1];
            return romanNumerals;
        }

    }
}
