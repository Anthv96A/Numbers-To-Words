
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumbersToWords.Tests
{
    [TestClass]
    public class TeensConverter_Tests
    {
       

        [TestMethod]
        public void Given_I_Have_A_Value_Of_11_The_Value_Returned_Should_Be_Eleven()
        {
            // Given I have a value of 11
            var value = 11;
            // When I pass the value into the word converter
            ITeensConverter converter = new TeensConverter();
            string result = converter.ConvertTeenNumbersToWord(value);
            // Then I expect the value returned is "eleven"
            Assert.AreEqual("eleven", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_12_The_Value_Returned_Should_Be_Twelve()
        {
            // Given I have a value of 12
            var value = 12;
            // When I pass the value into the word converter
            ITeensConverter converter = new TeensConverter();
            string result = converter.ConvertTeenNumbersToWord(value);
            // Then I expect the value returned is "twelve"
            Assert.AreEqual("twelve", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_13_The_Value_Returned_Should_Be_Thirteen()
        {
            // Given I have a value of 13
            var value = 13;
            // When I pass the value into the word converter
            ITeensConverter converter = new TeensConverter();
            string result = converter.ConvertTeenNumbersToWord(value);
            // Then I expect the value returned is "thirteen"
            Assert.AreEqual("thirteen", result);
        }
        [TestMethod]
        public void Given_I_Have_A_Value_Of_14_The_Value_Returned_Should_Be_Fourteen()
        {
            // Given I have a value of 14
            var value = 14;
            // When I pass the value into the word converter
            ITeensConverter converter = new TeensConverter();
            string result = converter.ConvertTeenNumbersToWord(value);
            // Then I expect the value returned is "fourteen"
            Assert.AreEqual("fourteen", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_15_The_Value_Returned_Should_Be_Fifteen()
        {
            // Given I have a value of 15
            var value = 15;
            // When I pass the value into the word converter
            ITeensConverter converter = new TeensConverter();
            string result = converter.ConvertTeenNumbersToWord(value);
            // Then I expect the value returned is "fifteen"
            Assert.AreEqual("fifteen", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_16_The_Value_Returned_Should_Be_Sixteen()
        {
            // Given I have a value of 16
            var value = 16;
            // When I pass the value into the word converter
            ITeensConverter converter = new TeensConverter();
            string result = converter.ConvertTeenNumbersToWord(value);
            // Then I expect the value returned is "sixteen"
            Assert.AreEqual("sixteen", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_17_The_Value_Returned_Should_Be_Seventeen()
        {
            // Given I have a value of 17
            var value = 17;
            // When I pass the value into the word converter
            ITeensConverter converter = new TeensConverter();
            string result = converter.ConvertTeenNumbersToWord(value);
            // Then I expect the value returned is "seventeen"
            Assert.AreEqual("seventeen", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_18_The_Value_Returned_Should_Be_Eighteen()
        {
            // Given I have a value of 18
            var value = 18;
            // When I pass the value into the word converter
            ITeensConverter converter = new TeensConverter();
            string result = converter.ConvertTeenNumbersToWord(value);
            // Then I expect the value returned is "eighteen"
            Assert.AreEqual("eighteen", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_19_The_Value_Returned_Should_Be_Nineteen()
        {
            // Given I have a value of 19
            var value = 19;
            // When I pass the value into the word converter
            ITeensConverter converter = new TeensConverter();
            string result = converter.ConvertTeenNumbersToWord(value);
            // Then I expect the value returned is "nineteen"
            Assert.AreEqual("nineteen", result);
        }

    }
}

