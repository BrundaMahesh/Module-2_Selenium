using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_20_11_2023
{
    internal class FlipkartTests:CoreCodes
    {

        [Test]
        [Order(1)]
        public void CloseFirstPop()
        {
            IWebElement popup= driver.FindElement(By.XPath("//*[@class='_30XB9F']"));
            popup.Click();
            Assert.AreEqual(driver.Url,"https://www.flipkart.com/");

        }

        [Test]
        [Order(2)]
        public void SearchProductTest()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";

            IWebElement searchInput = fluentWait.Until(d => d.FindElement(By.XPath("//input[@name='q']")));

            searchInput.SendKeys("laptop");
            searchInput.SendKeys(Keys.Enter);
            Assert.That(driver.Url.Contains("laptop"));

        }
        
    }
}
