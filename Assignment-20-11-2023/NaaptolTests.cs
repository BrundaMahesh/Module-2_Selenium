using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Security.Cryptography;
using System.Collections;
using System.IO;

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
        [TestCase(5)]
        public void SelectFifthProductTest(int pid)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";

            string path = "//div[@id='productItem" + pid + "']";
            Console.WriteLine(path);
            IWebElement clickFifthProduct = fluentWait.Until(d=>d.FindElement(By.XPath(path)));

            Actions actions = new Actions(driver);
            Action scroll = () => actions
            .MoveToElement(clickFifthProduct).Click()
            .Build()
            .Perform();

            scroll.Invoke();

            List<string> liswindow = driver.WindowHandles.ToList();
            driver.SwitchTo().Window(liswindow[1]);
            Assert.That(driver.Url.Contains("reading-glasses-with-led-lights-lrg4"));
        }

        [Test]
        [Order(3)]
        [TestCase("2.50")]
        public void AddProductToCartTest(string size)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";
           
            string path = "Black-" + size;
            
            Console.WriteLine(path);
            IWebElement chooseSize = fluentWait.Until(d => d.FindElement(By.LinkText(path)));

            chooseSize.Click();

            IWebElement clickHereToByButton = driver.FindElement(By.Id("cart-panel-button-0"));
            clickHereToByButton.Click();

            IWebElement prodName = fluentWait.Until(d => d.FindElement(By.LinkText("Reading Glasses with LED Lights (LRG4)")));
            Assert.AreEqual("Reading Glasses with LED Lights (LRG4)",prodName.Text);
        }

        [Test]
        [Order(4)]
        public void ViewShoppingCartTest()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";

            IWebElement closeButton = fluentWait.Until(d => d.FindElement(By.XPath("//a[@title='Close']")));
            closeButton.Click();

            string link = "https://www.naaptol.com/eyewear/reading-glasses-with-led-lights-lrg4/p/12612074.html";
            Assert.AreEqual(driver.Url,link);

        }

    }
}
