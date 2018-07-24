using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersToWords
{
    public interface INumberToWordConverter
    {
        string ConvertedNumberToWord(int input);
    }
}
