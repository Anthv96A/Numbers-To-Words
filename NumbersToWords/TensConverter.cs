using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersToWords
{
    public class TensConverter : ITensConverter
    {
   
        public string ConvertTensToWords(int input)
        {
            var tensMap = new[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            return tensMap[input / 10 - 2];
        }
    }
}
