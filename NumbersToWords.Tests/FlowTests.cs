using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace NumbersToWords.Tests
{
    [TestClass]
    public class FlowTests
    {
        [TestMethod]
        public void Given_I_Have_A_Value_Of_1_The_Unit_Converter_Should_be_called_once ()
        {
            // Given I have the value 1
            int input = 1;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the unit converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Once);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Never);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_2_The_Unit_Converter_Should_be_called_once()
        {
            // Given I have the value 2
            int input = 2;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the unit converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Once);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Never);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_3_The_Unit_Converter_Should_be_called_once()
        {
            // Given I have the value 3
            int input = 3;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the unit converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Once);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Never);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_10_The_Unit_Converter_Should_be_called_once()
        {
            // Given I have the value 10
            int input = 10;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the unit converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Once);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Never);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_11_The_Teens_Converter_Should_be_called_once()
        {
            // Given I have the value 11
            int input = 11;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the teens converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Never);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Once);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Never);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_19_The_Teens_Converter_Should_be_called_once()
        {
            // Given I have the value 19
            int input = 19;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the teens converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Never);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Once);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Never);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_20_The_Tens_Converter_Should_be_called_once()
        {
            // Given I have the value 20
            int input = 20;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the tens converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Never);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Once);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_21_The_Tens_And_Units_Converter_Should_be_called_once()
        {
            // Given I have the value 21
            int input = 21;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the tens and units converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Once);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Once);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_29_The_Tens_And_Units_Converter_Should_be_called_once()
        {
            // Given I have the value 29
            int input = 29;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);
            // Then verify that the tens and units converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Once);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Once);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_30_The_Tens_Converter_Should_be_called_once()
        {
            // Given I have the value 30
            int input = 30;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the tens converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Never);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Once);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }

        [TestMethod]
        public void Given_I_Have_A_Value_Of_55_The_Tens_And_Units_Converter_Should_be_called_once()
        {
            // Given I have the value 55
            int input = 55;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the tens and units converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Once);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Once);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_77_The_Tens_And_Units_Converter_Should_be_called_once()
        {
            // Given I have the value 77
            int input = 77;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the tens and units converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Once);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Once);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_90_The_Tens_Converter_Should_be_called_once()
        {
            // Given I have the value 90
            int input = 90;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the tens and units converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Never);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Once);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_99_The_Tens_And_Units_Converter_Should_be_called_once()
        {
            // Given I have the value 99
            int input = 99;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the tens and units converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Once);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Once);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Never);
        }


        [TestMethod]
        public void Given_I_Have_A_Value_Of_100_The_Hundred_Converter_Should_be_called_once()
        {
            // Given I have the value 100
            int input = 100;

            // When I pass the value into the word converter
            // And I pass a mock IUnitConverter
            // And I pass a mock ITeensConverter
            // And I pass a mock ITensConverter
            // And I pass a mock IHundredConverter

            Mock<IUnitsConverter> unitMock = new Mock<IUnitsConverter>();
            Mock<ITeensConverter> teensMock = new Mock<ITeensConverter>();
            Mock<ITensConverter> tensMocks = new Mock<ITensConverter>();
            Mock<IHundredConverter> hundredMocks = new Mock<IHundredConverter>();

            INumberToWordConverter flow = new NumberToWordConverter
                (tensMocks.Object, teensMock.Object, unitMock.Object, hundredMocks.Object);

            flow.ConvertedNumberToWord(input);

            // Then verify that the tens and units converter is called once
            unitMock.Verify(m => m.ConvertSingleNumberToWord(It.IsAny<int>()), Times.Never);
            teensMock.Verify(m => m.ConvertTeenNumbersToWord(It.IsAny<int>()), Times.Never);
            tensMocks.Verify(m => m.ConvertTensToWords(It.IsAny<int>()), Times.Never);
            hundredMocks.Verify(m => m.ConvertValueHundredToWordHundred(), Times.Once);
        }
    }
}
