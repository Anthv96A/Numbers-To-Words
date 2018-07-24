using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersToWords
{
    public class UnitsConverter : IUnitsConverter
    {
        
        public string ConvertSingleNumberToWord(int input)
        {
            var unitsMap = new[] {"zero","one","two","three","four","five","six","seven","eight","nine","ten"};
            return unitsMap[input];
        }
    }
}
