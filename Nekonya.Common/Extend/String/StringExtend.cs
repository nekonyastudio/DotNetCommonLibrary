/*
 * This file is part of the "Nekonya studio common library".
 * https://github.com/nekonyastudio/DotNetCommonLibrary
 *
 * (c) Nekonya Studio <yomunsam@gmail.com>
 * https://nekonya.io
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using Nekonya.Utils;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Nekonya
{
    public static class StringExtend
    {
        /// <summary>
        /// Is Email Address | 是否为邮箱地址
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsMail(this string str) => Regex.IsMatch(str,
            @"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$");


        /// <summary>
        /// Reverse specified string. | 反转字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(this string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }


        /// <summary>
        /// UTF8 string to base64 | 字符串编码到Base64
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EncodeBase64(this string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// UTF8 from base64 to string | Base64文本解码到字符串
        /// </summary>
        /// <param name="base64_str"></param>
        /// <returns></returns>
        public static string DecodeBase64(this string base64_str)
        {
            var b = Convert.FromBase64String(base64_str);
            return Encoding.UTF8.GetString(b);
        }

        public static bool IsNullOrEmpty(this string str) 
            => string.IsNullOrEmpty(str);

        public static bool IsNullOrWhiteSpace(this string str)
            => string.IsNullOrWhiteSpace(str);

        public static string GetMD5(this string str, bool lower = true, bool shortMD5 = false)
        {
            return EncryUtil.GetMD5(str, lower, shortMD5);
        }

    }
}
