using Rediff.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rediff.TestScripts
{
    [TestFixture]
    internal class UserManagementTests : CoreCodes
    {
        //Asserts
        [Test]
        [Order(1)]
        public void CreateAccountLinkTest()
        {
            var homePage = new RediffHomePage(driver);
            homePage.CreateAccountLinkClick();

            Assert.That(driver.Url.Contains("register"));
        }
    }
}