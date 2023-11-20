using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitExamples
{
    [TestFixture]
    internal class LinkedinTests:CoreCodes
    {
        [Test]
        [Author("Brunda","brunda@gmail.com")]
        [Description("Check for valid login")]
        [Category("Regression testing")]
        public void Login1Test()
        {
            Thread.Sleep(3000);
            IWebElement emailInput = driver.FindElement(By.Id("session_key"));
            IWebElement passwordInput= driver.FindElement(By.Id("session_password"));
            emailInput.SendKeys("abc@gmail.com");
            passwordInput.SendKeys("12345");
            Thread.Sleep(3000);
        }
        [Test]
        [Author("Brunda", "brunda@gmail.com")]
        [Description("Check for invalid login")]
        [Category("Smoke testing")]
        public void Login2Test()
        {

        }
        [Test]
        [Author("AAA", "AAA@gmail.com")]
        [Description("Check for invalid login")]
        [Category("Regression testing")]
        public void Login3Test()
        {

        }
    }
}
