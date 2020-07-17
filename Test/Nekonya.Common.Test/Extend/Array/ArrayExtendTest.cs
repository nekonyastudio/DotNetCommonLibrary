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


        [Test]
        public void AddElement()
        {
            string[] arr1 = { "hello" };
            var newArr = arr1.Add("world");

            Assert.IsTrue(newArr.Length == 2);
            Assert.IsTrue(newArr[0].Equals(arr1[0]));
            Assert.IsTrue(newArr[1].Equals("world"));
        }

        [Test]
        public void AddRange()
        {
            string[] arr1 = { "hello" };
            string[] arr2 = { "world", "meow" };

            var newArr = arr1.AddRange(arr2);

            Assert.IsTrue(newArr.Length == 3);
            Assert.IsTrue(newArr[0].Equals(arr1[0]));
            Assert.IsTrue(newArr[1].Equals(arr2[0]));
            Assert.IsTrue(newArr[2].Equals(arr2[1]));
        }

    }
}
