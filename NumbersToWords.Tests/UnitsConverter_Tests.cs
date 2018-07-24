using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumbersToWords.Tests
{
    [TestClass]
    public class UnitsConverter_Tests
    {
        [TestMethod]
        public void Given_I_Have_A_Value_Of_1_The_Value_Returned_Should_Be_One()
        {
            // Given I have a value of 1
            var value = 1;

            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);

            // Then I expect the value returned is "one"
            Assert.AreEqual("one", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_2_The_Value_Returned_Should_Be_Two()
        {
            // Given I have a value of 2
            var value = 2;
            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);
            // Then I expect the value returned is "two"
            Assert.AreEqual("two", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_3_The_Value_Returned_Should_Be_Three()
        {
            // Given I have a value of 3
            var value = 3;
            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);
            // Then I expect the value returned is "three"
            Assert.AreEqual("three", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_4_The_Value_Returned_Should_Be_Four()
        {
            // Given I have a value of 4
            var value = 4;
            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);
            // Then I expect the value returned is "four"
            Assert.AreEqual("four", result);

        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_5_The_Value_Returned_Should_Be_Five()
        {
            // Given I have a value of 5
            var value = 5;
            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);
            // Then I expect the value returned is "five"
            Assert.AreEqual("five", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_6_The_Value_Returned_Should_Be_Six()
        {
            // Given I have a value of 6
            var value = 6;
            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);
            // Then I expect the value returned is "six"
            Assert.AreEqual("six", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_7_The_Value_Returned_Should_Be_Seven()
        {
            // Given I have a value of 7
            var value = 7;
            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);
            // Then I expect the value returned is "seven"
            Assert.AreEqual("seven", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_8_The_Value_Returned_Should_Be_Eight()
        {
            // Given I have a value of 8
            var value = 8;
            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);
            // Then I expect the value returned is "eight"
            Assert.AreEqual("eight", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_9_The_Value_Returned_Should_Be_Nine()
        {
            // Given I have a value of 9
            var value = 9;
            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);
            // Then I expect the value returned is "nine"
            Assert.AreEqual("nine", result);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_10_The_Value_Returned_Should_Be_Ten()
        {
            // Given I have a value of 10
            var value = 10;
            // When I pass the value into the word converter
            IUnitsConverter converter = new UnitsConverter();
            string result = converter.ConvertSingleNumberToWord(value);
            // Then I expect the value returned is "ten"
            Assert.AreEqual("ten", result);
        }
    }
}
