using System;

namespace TokenRepository.Client.Utility
{
    public static class Formatter
    {
        public const string _DateTimeStandardFormatString = "yyyy-MM-dd HH:mm:ss";
        public const string _SysDefaultDate = "1900-01-01 00:00:00";
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
