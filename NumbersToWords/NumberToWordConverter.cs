using System;
using System.Collections.Generic;

namespace NumbersToWords
{
    public class NumberToWordConverter : INumberToWordConverter
    {
        private readonly ITensConverter iTensConverter;
        private readonly ITeensConverter iTeensConverter;
        private readonly IUnitsConverter iUnitConverter;
        private readonly IHundredConverter iHundredConverter;

        public NumberToWordConverter(ITensConverter iTensConverter, ITeensConverter iTeensConverter, IUnitsConverter iUnitConverter, IHundredConverter iHundredConverter)
        {
            this.iTensConverter = iTensConverter;
            this.iTeensConverter = iTeensConverter;
            this.iUnitConverter = iUnitConverter;
            this.iHundredConverter = iHundredConverter;
        }
    

        public string ConvertedNumberToWord(int input)
        {
            string word = "";

            if (input <= 10)
            {
                word += iUnitConverter.ConvertSingleNumberToWord(input);
            }
            else if (input < 20 && input > 10)
            {
                word += iTeensConverter.ConvertTeenNumbersToWord(input);
            }
            else if(input < 100 && input >= 20)
            {
                word += iTensConverter.ConvertTensToWords(input);

                if(input % 10 != 0)
                {
                    int remainder = input % 10;
                    word += " " + iUnitConverter.ConvertSingleNumberToWord(remainder);
                }
            }
            else
            {
                word += iHundredConverter.ConvertValueHundredToWordHundred();
            }

            return word;
        }
    }
}
