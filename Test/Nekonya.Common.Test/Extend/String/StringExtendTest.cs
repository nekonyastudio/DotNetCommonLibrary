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

namespace Nekonya.Common.Test.Extend.String
{
    public class StringExtendTest
    {
        [Test]
        [TestCase("abc@gmail.com",true)]
        [TestCase("abc@gmail.com@", false)]
        [TestCase("meow.com",false)]
        [TestCase("meow",false)]
        [TestCase("123@1.com",true)]
        public void IsMail(string mail, bool assert)
        {
            if (assert)
                Assert.IsTrue(mail.IsMail(), $"mail \"{mail}\" should be true");
            else
                Assert.IsFalse(mail.IsMail(), $"mail \"{mail}\" should be false");
        }
    }
}
