/*
 * This file is part of the "Nekonya studio common library".
 * https://github.com/nekonyastudio/DotNetCommonLibrary
 *
 * (c) Nekonya Studio <me@yomunchan.moe> <yomunsam@nekonya.io>
 * https://nekonya.io
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System.Security.Cryptography;
using System.Text;

namespace Nekonya.Utils;

public static class EncryUtil
{
    /// <summary>
    /// Get string MD5
    /// 获取字符串的MD5值
    /// </summary>
    /// <param name="content"></param>
    /// <param name="lower">Result is lowercase | 返回小写字母MD5</param>
    /// <returns></returns>
    public static string GetMD5(string content, bool lower = true, bool shortMD5 = false)
    {
        MD5 md5Hash = MD5.Create();
        var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(content));
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            str.Append(data[i].ToString(lower ? "x2" : "X2"));
        }
        return shortMD5 ? str.ToString().Substring(8, 16) : str.ToString();
    }
}
