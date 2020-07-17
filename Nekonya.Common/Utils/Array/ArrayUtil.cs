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

/*
 * 本页部分代码搬运自CatLib(https://github.com/CatLib/Core) （MIT开源协议）
 */

using System;

namespace Nekonya.Utils
{
    public static class ArrayUtil
    {
        /// <summary>
        /// Combine multiple specified arrays into one array.
        /// 将给定的多个数组合并成一个数组
        /// </summary>
        /// <param name="sources"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] Merge<T>(params T[][] sources)
        {
            if (sources == null || sources.Length <= 0)
            {
                return Array.Empty<T>();
            }

            var totalSize = 0;
            foreach (var source in sources)
            {
                if (source == null || source.Length <= 0)
                {
                    continue;
                }
                totalSize += source.Length;
            }
            if (totalSize <= 0)
            {
                return Array.Empty<T>();
            }
            var merged = new T[totalSize];
            var length = 0;
            foreach (var source in sources)
            {
                if (source == null || source.Length <= 0)
                {
                    continue;
                }

                Array.Copy(source, 0, merged, length, source.Length);
                length += source.Length;
            }

            return merged;
        }

        public static T[] Add<T>(T[] source, T element)
        {
            long length = source.LongLength;
            var result = new T[length + 1];
            source.CopyTo(result, 0);
            result[length] = element;
            return result;
        }
    }
}