using System;

namespace TokenRepository.Backend.Utility
{
    public static class ConvertUtil
    {
        public static bool ToBoolean(string inputValue)
        {
            string boolTempString = inputValue;
            if (string.IsNullOrWhiteSpace(boolTempString))
            {
                boolTempString = bool.FalseString;
            }
            else
            {
                if (boolTempString.Equals("1") || boolTempString.Equals("yes", StringComparison.CurrentCultureIgnoreCase) ||
                    boolTempString.Equals("y", StringComparison.CurrentCultureIgnoreCase))
                    boolTempString = bool.TrueString;
                else if (boolTempString.Equals("0") || boolTempString.Equals("no", StringComparison.CurrentCultureIgnoreCase) ||
                    boolTempString.Equals("n", StringComparison.CurrentCultureIgnoreCase))
                    boolTempString = bool.FalseString;
                else if (!boolTempString.Equals(bool.TrueString, StringComparison.CurrentCultureIgnoreCase) &&
                    !boolTempString.Equals(bool.FalseString, StringComparison.CurrentCultureIgnoreCase))
                    boolTempString = bool.FalseString;
            }
            return bool.Parse(boolTempString);
        }
    }
}
