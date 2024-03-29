﻿/*
 * This file is part of the "Nekonya studio common library".
 * https://github.com/nekonyastudio/DotNetCommonLibrary
 *
 * (c) Nekonya Studio <me@yomunchan.moe> <yomunsam@nekonya.io>
 * https://nekonya.io
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */


using System;
using System.Text;

namespace Nekonya.Utils.String;

public static class StringUtil
{
    /// <summary>
    /// Generate a random letter (with case), a string of numbers. | 生成一个随机字母（含大小写），数字的字符串。
    /// </summary>
    /// <param name="length">The length of the generate string. | 生成字符串长度</param>
    /// <param name="seed">The random seed. | 随机种子</param>
    /// <returns></returns>
    public static string GetRandom(int length = 16, int? seed = null)
    {
        length = Math.Max(1, length);

        var ret = new StringBuilder();
        var random = MakeRandom(seed);
        for (int len; (len = ret.Length) < length;)
        {
            var size = length - len;
            var bytes = new byte[size];
            random.NextBytes(bytes);

            var code = Replace(new[] { "/", "+", "=" }, string.Empty, Convert.ToBase64String(bytes));
            ret.Append(code[..Math.Min(size, code.Length)]);
        }
        return ret.ToString();
    }


    /// <summary>
    /// Replace the match in the specified string. | 在规定字符串中替换匹配项。
    /// </summary>
    /// <param name="matches">An array of the match string. </param>
    /// <param name="replace">The replacement value.</param>
    /// <param name="str">The specified string.</param>
    /// <returns></returns>
    public static string Replace(string[] matches, string replace, string str)
    {
        matches ??= Array.Empty<string>(); //matches = matches ?? Array.Empty<string>();
        replace ??= string.Empty;

        if (string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }

        foreach (var match in matches)
        {
            if (match == null)
            {
                continue;
            }

            str = str.Replace(match, replace);
        }

        return str;
    }

    private static Random MakeRandom(int? seed = null)
    {
        return new Random(seed.GetValueOrDefault(MakeSeed()));
    }

    private static int MakeSeed()
    {
        return Environment.TickCount ^ Guid.NewGuid().GetHashCode();
    }
}
