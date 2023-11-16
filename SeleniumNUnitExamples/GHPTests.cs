using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitExamples
{
    [TestFixture]
    internal class GHPTests:CoreCodes
    {
        [Test]
        public void TitleTest()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Title: " + driver.Title);
            Console.WriteLine("Title length: " + driver.Title.Length);
            Assert.AreEqual("Google", driver.Title);
            Console.WriteLine("Title test - Pass");
        }
    }
}
