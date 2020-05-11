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

namespace Nekonya.Common.Test.Extend.Array
{
    public class ArrayExtendTest
    {
        [Test]
        public void IsNullOrEmpty()
        {
            string[] arr1 = null;
            Assert.IsTrue(arr1.IsNullOrEmpty(), "Arr1 should be null");

            string[] arr2 = new string[0];
            Assert.IsTrue(arr2.IsNullOrEmpty(), "Arr2 should be empty");

            string[] arr3 = new string[] { "", "meow", "😺"};
            Assert.IsFalse(arr3.IsNullOrEmpty(), "Arr3 should not be empty or null");
        }


        [Test]
        public void Foreach()
        {
            string[] arr1 = { "", "meow", "❤", "nya~" };
            arr1.Foreach((i, item) =>
            {
                TestContext.WriteLine($"index: {i} : {item}");
            });
            
        }
    }
}
