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

using Nekonya.Utils;
using System;

namespace Nekonya;

public static class ArrayExtend
{
    
    /// <summary>
    /// Foreach with index.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr"></param>
    /// <param name="each">long: index, T: foreach item</param>
    public static void Foreach<T>(this T[] arr, Action<long, T> each)
    {
        for (long i = 0; i < arr.LongLength; i++)
        {
            each?.Invoke(i, arr[i]);
        }
    }

    public static T[] Add<T>(this T[] source, T element)
    {
        return ArrayUtil.Add(source, element);
    }

    public static T[] AddRange<T>(this T[] source, T[] ranges)
    {
        return ArrayUtil.Merge(source, ranges);
    }

}
