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

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Nekonya;

public static class ListExtend
{

    /// <summary>
    /// if key not exist, add it to list and return 'true',  or else return 'false'
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list"></param>
    /// <param name="addItem"></param>
    /// <returns></returns>
    public static bool AddIfNotExist<T>(this IList<T> list, T addItem)
    {
        if (list.Contains(addItem)) 
            return false;
        list.Add(addItem);
        return true;
    }

    /// <summary>
    /// IList is null or IList count is 0.
    /// </summary>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static bool IsNullOrEmpty<T>([NotNullWhen(false)] this IList<T>? list)
    {
        if (list == null)
            return true;
        return (list.Count == 0);
    }
}
