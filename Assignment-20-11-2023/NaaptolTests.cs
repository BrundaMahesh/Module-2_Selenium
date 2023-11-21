using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Assignment_20_11_2023
{
    [TestFixture]
    internal class NaaptolTests:CoreCodes
    {
        [Test]
        [Order(1)]
        public void SearchProductTest()
        {
            driver.Navigate().GoToUrl("https://www.naaptol.com/");

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";

            IWebElement searchInput = fluentWait.Until(d=>d.FindElement(By.Id("header_search_text")));

            searchInput.SendKeys("eyewear");
            searchInput.SendKeys(Keys.Enter);

            Assert.That(driver.Url.Contains("eyewear"));
        }

        [Test]
        [Order(2)]
        public void SelectFifthProduct()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";
           
            
            IWebElement clickFifthProduct = fluentWait.Until(d=>d.FindElement(By.XPath("//div[@id='productItem5' and @pid='12612074']")));

            Actions actions = new Actions(driver);
            Action scroll = () => actions
            .MoveToElement(clickFifthProduct).Click()
           .Build()
            .Perform();

            scroll.Invoke();
           
            List<string> liswindow = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(liswindow[1]);
        }
    }
}
