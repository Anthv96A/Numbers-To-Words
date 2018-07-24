using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumbersToWords.Tests
{
    [TestClass]
    public class TensConverter_Tests
    {
        [TestMethod]
        public void Given_I_Have_A_Value_Of_20_The_Value_Returned_Should_Be_Twenty()
        {
            // Given I have a value of 20
            var value = 20;

            // When I pass the value into the word converter
            ITensConverter converter = new TensConverter();
            string result = converter.ConvertTensToWords(value);

            // Then I expect the value returned is "twenty"
            Assert.AreEqual("twenty", result);
        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_30_The_Value_Returned_Should_Be_Thirty()
        {
            // Given I have a value of 30
            var value = 30;

            // When I pass the value into the word converter
            ITensConverter converter = new TensConverter();
            string result = converter.ConvertTensToWords(value);

            // Then I expect the value returned is "thirty"
            Assert.AreEqual("thirty", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_40_The_Value_Returned_Should_Be_Fourty()
        {
            // Given I have a value of 40
            var value = 40;

            // When I pass the value into the word converter
            ITensConverter converter = new TensConverter();
            string result = converter.ConvertTensToWords(value);

            // Then I expect the value returned is "fourty"
            Assert.AreEqual("fourty", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_50_The_Value_Returned_Should_Be_Fifty()
        {
            // Given I have a value of 50
            var value = 50;

            // When I pass the value into the word converter
            ITensConverter converter = new TensConverter();
            string result = converter.ConvertTensToWords(value);

            // Then I expect the value returned is "fifty"
            Assert.AreEqual("fifty", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_60_The_Value_Returned_Should_Be_Sixty()
        {
            // Given I have a value of 60
            var value = 60;

            // When I pass the value into the word converter
            ITensConverter converter = new TensConverter();
            string result = converter.ConvertTensToWords(value);

            // Then I expect the value returned is "sixty"
            Assert.AreEqual("sixty", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_70_The_Value_Returned_Should_Be_Seventy()
        {
            // Given I have a value of 70
            var value = 70;

            // When I pass the value into the word converter
            ITensConverter converter = new TensConverter();
            string result = converter.ConvertTensToWords(value);

            // Then I expect the value returned is "seventy"
            Assert.AreEqual("seventy", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_80_The_Value_Returned_Should_Be_Eighty()
        {
            // Given I have a value of 80
            var value = 80;

            // When I pass the value into the word converter
            ITensConverter converter = new TensConverter();
            string result = converter.ConvertTensToWords(value);
            // Then I expect the value returned is "eighty"
            Assert.AreEqual("eighty", result);
        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_90_The_Value_Returned_Should_Be_Ninty()
        {
            // Given I have a value of 90
            var value = 90;

            // When I pass the value into the word converter
            ITensConverter converter = new TensConverter();
            string result = converter.ConvertTensToWords(value);

            // Then I expect the value returned is "ninty"
            Assert.AreEqual("ninty", result);
        }
    }
}
