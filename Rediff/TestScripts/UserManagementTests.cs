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
        /*
        [Test,Order(1),Category("Smoke Test")]
        public void CreateAccountLinkTest()
        {
            var homePage = new RediffHomePage(driver);
            driver.Navigate().GoToUrl("https://www.rediff.com/");
            homePage.CreateAccountLinkClick();

            Assert.That(driver.Url.Contains("register"));
        }

        [Test,Order(2),Category("Smoke Test")]
        public void SignInLinkTest()
        {

            var homePage = new RediffHomePage(driver);
            driver.Navigate().GoToUrl("https://www.rediff.com/");
            homePage.SignInLinkClick();

            Assert.That(driver.Url.Contains("login"));
        }
        */

        //[Test, Order(1), Category("Regression Test")]
        //public void CreateAccountTest()
        //{
        //    var homePage = new RediffHomePage(driver);
        //    if (!driver.Url.Contains("https://www.rediff.com/"))
        //    {
        //        driver.Navigate().GoToUrl("https://www.rediff.com/");
        //    }
        //    var  createAccountPage = homePage.CreateAccountClick();
        //    createAccountPage.FullNameType("Akash");
        //    createAccountPage.RediffmailType("akash");
        //    createAccountPage.CheckAvailabilityButtonClick();
        //    Thread.Sleep(3000);

        //    createAccountPage.CreateMyAccountBtnClick();
        //    //Assert.That(driver.Url.Contains("register"));
        //}

        [Test, Order(2), Category("Regression Test")]
        public void SignInTest()
        {
            var homePage = new RediffHomePage(driver);
            if (!driver.Url.Contains("https://www.rediff.com/"))
            {
                driver.Navigate().GoToUrl("https://www.rediff.com/");
            }
            var signInPage = homePage.SignInClick();
            signInPage.UserNameType("Abhi");
            signInPage.PasswordType("password");
            signInPage.KeepSignInCheckBoxClick();
            Assert.False(signInPage?.KeepSignInCheckBox?.Selected);

            Thread.Sleep(3000);

            signInPage?.SignInBtnClick();
        }
    }
}