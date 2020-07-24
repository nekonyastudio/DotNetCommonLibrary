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

using NUnit.Framework;
using System.Collections.Generic;
using Nekonya;

namespace Nekonya.Common.Test.Extend.Lists
{
    public class ListExtendTest
    {
        [Test]
        public void IsNullOrEmpty()
        {
            List<string> list1 = null;
            Assert.IsTrue(list1.IsNullOrEmpty(),"List 1 should be null");

            List<string> list2 = new List<string>();
            Assert.IsTrue(list2.IsNullOrEmpty(), "List 2 should be empty");

            List<string> list3 = new List<string> { "", "meow", "😺"};
            Assert.IsFalse(list3.IsNullOrEmpty(), "List 3 should not be empty or null");
        }
    }
}
