using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_14_11_2023
{
    internal class NavigationTests
    {
        IWebDriver driver;

        public void InitializeChromeDriver()
        {
            driver= new ChromeDriver();
            driver.Url = "https://www.google.com";
            driver.Manage().Window.Maximize();
        }

        public void GoToYahooTest()
        {
            driver.Navigate().GoToUrl("https://www.yahoo.com");
            Thread.Sleep(1000);
            Assert.AreEqual("Yahoo | Mail, Weather, Search, Politics, News, Finance, Sports & Videos", driver.Title);
            Console.WriteLine("Go to Yahoo test - Pass");
        }
        public void BackToGoogleTest()
        {  
            driver.Navigate().Back();
            Thread.Sleep(2000);
            Assert.AreEqual("Google",driver.Title);
            Console.WriteLine("Back to Google test - Pass");
        }
        public void BackToYahooTest()
        { 
            driver.Navigate().Forward();
            Thread.Sleep(2000);
            Assert.AreEqual("Yahoo | Mail, Weather, Search, Politics, News, Finance, Sports & Videos", driver.Title);
            Console.WriteLine("Back to Yahoo test - Pass");
        }

        public void BackToGoogleAgainTest()
        {
            driver.Navigate().Back();
            Thread.Sleep(2000);
            Assert.AreEqual("Google", driver.Title);
            Console.WriteLine("Back to Google again test - Pass");
        }
        public void GSTest()
        {
            IWebElement searchInputTextBox = driver.FindElement(By.Id("APjFqb"));
            searchInputTextBox.SendKeys("What's special for Diwali 2023");
            Thread.Sleep(6000);
            IWebElement gsButton = driver.FindElement(By.ClassName("gNO89b"));
            gsButton.Click();
            Assert.AreEqual("What's special for Diwali 2023 - Google Search", driver.Title);
            Console.WriteLine("GS test - Pass");
        }
        public void RefreshTest()
        {
            driver.Navigate().Refresh();
            Thread.Sleep(3000);
            Assert.AreEqual("What's special for Diwali 2023 - Google Search", driver.Title);
            Console.WriteLine("Refresh test - Pass");
        }
        public void Exit()
        {
            driver.Close();
        }
    }
}
