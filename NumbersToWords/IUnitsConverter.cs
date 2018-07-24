using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersToWords
{
    public interface IUnitsConverter
    {
        string ConvertSingleNumberToWord(int input);
    }
}
