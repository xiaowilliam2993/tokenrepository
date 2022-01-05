using System;

namespace TokenRepository.Backend.Utility
{
    public static class Formatter
    {
        public const string _DateTimeStandardFormatString = "yyyy-MM-dd HH:mm:ss";
        public static string ToStringEx(this DateTime dateTime)
        {
            return dateTime.ToString(_DateTimeStandardFormatString);
        }
        public static string ToStringEx(this DateTime dateTime, string formatString)
        {
            return dateTime.ToString(formatString);
        }
    }
}
