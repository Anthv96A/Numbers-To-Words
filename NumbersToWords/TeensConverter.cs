using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersToWords
{
    public class TeensConverter : ITeensConverter
    {
        public string ConvertTeenNumbersToWord(int input)
        {
            var teensMap = new[] { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
            return teensMap[input - 11];
        }
    }
}
