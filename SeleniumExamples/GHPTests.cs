using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumExamples
{
    internal class GHPTests
    {
        IWebDriver driver;
        public void InitializeChromeDriver()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
        }
        public void InitializeEdgeDriver()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.google.com/";
            driver.Manage().Window.Maximize();
        }
        public void TitleTest()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Title: "+driver.Title);
            Console.WriteLine("Title length: "+ driver.Title.Length);
            Assert.AreEqual("Google", driver.Title);
            Console.WriteLine("Title test - Pass");
        }
        public void PageSourceAndURLTest()
        {
            //Console.WriteLine("Page source: "+driver.PageSource);
            Console.WriteLine("Page source length: "+driver.PageSource.Length);
            Console.WriteLine("Page URl: " + driver.Url);
            Assert.AreEqual("https://www.google.com/", driver.Url);
            Console.WriteLine("PageSourceAndURL test - Pass");
        }
        public void GSTest()
        {
            IWebElement searchInputTextBox = driver.FindElement(By.Id("APjFqb"));
            searchInputTextBox.SendKeys("Dell laptop");
            Thread.Sleep(2000);
            //IWebElement gsButton = driver.FindElement(By.Name("btnK"));
            IWebElement gsButton = driver.FindElement(By.ClassName("gNO89b"));
            gsButton.Click();
            Assert.AreEqual("Dell laptop - Google Search",driver.Title);
            Console.WriteLine("GS test - Pass");
        }

        public void GmailLinkTest()
        {
            driver.Navigate().Back();
            driver.FindElement(By.LinkText("Gmail")).Click();
            Thread.Sleep(3000);
            //Assert.That(driver.Title.Contains("Gmail"));
            Assert.That(driver.Url.Contains("gmail"));
            Console.WriteLine("Gmail link test - Pass");
        }
        public void ImagesLinkTest()
        {
            driver.Navigate().Back();
            driver.FindElement(By.PartialLinkText("mag")).Click();
            Thread.Sleep(3000);
            Assert.That(driver.Title.Contains("Images"));
            Console.WriteLine("Images link test - Pass");
        }
        public void LocalizationTest()
        {
            driver.Navigate().Back();
            string local=driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div[1]")).Text;
            Thread.Sleep(3000);
            Assert.That(local.Equals("India"));
            Console.WriteLine("Localization test - Pass");
        }

        public void GAppYoutubeTest()
        {
            driver.FindElement(By.ClassName("gb_d")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/c-wiz/div/div/c-wiz/div/div/div[2]/div[2]/div[1]/ul/li[4]/a/div/span")).Click();
            Thread.Sleep(3000);
            Assert.That("Youtube".Equals(driver.Title));
        }

        public void Destruct()
        {
            driver.Close();
        }
    }
}
