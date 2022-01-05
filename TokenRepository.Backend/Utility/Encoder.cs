using Microsoft.VisualBasic;
using System;
using System.Text;

namespace TokenRepository.Backend.Utility
{
    /// <summary>
    /// 编码器
    /// </summary>
    public sealed class Encoder
    {
        /// <summary>
        /// 字符串加密
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ToEncoding(string inputString)
        {
            return Strings.StrReverse(Convert.ToBase64String(Encoding.ASCII.GetBytes(Strings.StrReverse(inputString))));
        }

        /// <summary>
        /// 字符串解密
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ToDeconding(string inputString)
        {
            return Strings.StrReverse(Encoding.ASCII.GetString(Convert.FromBase64String(Strings.StrReverse(inputString))));
        }
    }
}
