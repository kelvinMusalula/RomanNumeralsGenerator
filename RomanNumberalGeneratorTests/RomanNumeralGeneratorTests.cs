using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralGenerator;

namespace RomanNumeralGeneratorTests
{
    [TestClass]
    public class RomanNumeralTest
    {
        RomanNumerals numeralGenerator = new RomanNumerals();

        [TestMethod]
        public void Numeral_I_1()
        {
            Assert.AreEqual("I", numeralGenerator.generate(1));
        }

        [TestMethod]
        public void Numeral_V_5()
        {
            Assert.AreEqual("V", numeralGenerator.generate(5));
        }

        [TestMethod]
        public void Numeral_X_10()
        {
            Assert.AreEqual("X", numeralGenerator.generate(10));
        }

        [TestMethod]
        public void Numeral_XX_20()
        {
            Assert.AreEqual("XX", numeralGenerator.generate(20));
        }

        [TestMethod]
        public void Numeral_MMMCMXCIX_3999()
        {
            Assert.AreEqual("MMMCMXCIX", numeralGenerator.generate(3999));
        }

        [TestMethod]
        public void Numeral_Greater_Than_3999()
        {
            Assert.AreEqual("Make sure the number you enter is between 1 and 3999", numeralGenerator.generate(50000));
        }

        [TestMethod]
        public void Numeral_Less_Than_1()
        {
            Assert.AreEqual("Make sure the number you enter is between 1 and 3999", numeralGenerator.generate(-1));
        }
    }
}
