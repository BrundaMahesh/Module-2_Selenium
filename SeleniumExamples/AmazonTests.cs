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
    internal class AmazonTests
    {
        IWebDriver driver;
        public void InitializeChromeDriver()
        {
            driver= new ChromeDriver();
            driver.Url = "https://www.amazon.com/";
            driver.Manage().Window.Maximize();
        }
        public void InitializeEdgeDriver()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.amazon.com/";
            driver.Manage().Window.Maximize();
        }
        public void TitleTest()
        {
            //Console.WriteLine("Title: "+driver.Title);
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
            Console.WriteLine("Title test - Pass");
        }
        public void LogoClickTest()
        {
            driver.FindElement(By.Id("nav-logo-sprites")).Click();
            Assert.AreEqual("Amazon.com. Spend less. Smile more.", driver.Title);
            Console.WriteLine("Logo click test - Pass");

        }
        public void SearchProductTest()
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("mobiles");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
            Assert.That(("Amazon.com : mobiles".Equals(driver.Title) 
                && (driver.Url.Contains("mobiles"))));
            Console.WriteLine("Search Product test - Pass");
        }
        public void ReloadHomePageTest()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com");
            Thread.Sleep(3000);
            Console.WriteLine("Reload home page test - Pass");
        }
        public void TodaysDealsTest()
        {
            IWebElement todaysdeals = driver.FindElement(By.LinkText("Today's Deals"));
            if(todaysdeals == null)
            { 
                throw new NoSuchElementException("Today's deals link not present");
            }
            todaysdeals.Click();
            Assert.That(driver.FindElement(By.TagName("h1")).Text.Equals("Today's Deals"));
            Console.WriteLine("Today's deals test - Pass");
        }
        public void Destruct()
        {
            driver.Close();
        }
    }
}
