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
            IWebElement gsButton = driver.FindElement(By.Name("btnK"));
            gsButton.Click();
            Assert.AreEqual("Dell laptop - Google Search",driver.Title);
            Console.WriteLine("GS test - Pass");
        }

        public void Destruct()
        {
            driver.Close();
        }
    }
}
