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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

namespace Nekonya;

public static class DictionaryExtend
{
    public static void Foreach<TKey, TValue>(this IDictionary<TKey, TValue> dict, Action<TKey, TValue> each)
    {
        foreach (var item in dict)
        {
            each?.Invoke(item.Key, item.Value);
        }
    }

    public static dynamic ToDynamic(this IDictionary dict)
    {
        IDictionary<string, object> dy = new ExpandoObject();
        foreach (var key in dict.Keys)
        {
            var v1 = dict[key];
            var dyPropName = key.ToString();
            if (!dy.ContainsKey(dyPropName))
            {
                dy.Add(dyPropName, v1);
            }
        }
        return (ExpandoObject)dy;
    }

    public static bool AddIfNotExist<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
    {
        if (!dict.ContainsKey(key))
        {
            dict.Add(key, value);
            return true;
        }
        return false;
    }

    /// <summary>
    /// If key not exist , add key-value , or override value.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dict"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    public static void AddOrOverride<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
    {
        if (!dict.ContainsKey(key))
            dict.Add(key, value);
        else
            dict[key] = value;
    }

}
