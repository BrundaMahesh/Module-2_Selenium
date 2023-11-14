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
            Console.WriteLine("Go to Yahoo test - Pass");
        }
        public void BackToGoogleTest()
        {
            
            driver.Navigate().Back();
            //Thread.Sleep(1000);
            Console.WriteLine("Back to Google test - Pass");
        }
        public void GSTest()
        {
            IWebElement searchInputTextBox = driver.FindElement(By.Id("APjFqb"));
            searchInputTextBox.SendKeys("What special for Diwali 2023?");
            Thread.Sleep(2000);
            //IWebElement gsButton = driver.FindElement(By.Name("btnK"));
            IWebElement gsButton = driver.FindElement(By.ClassName("gNO89b"));
            gsButton.Click();
            Console.WriteLine("GS test - Pass");
        }
        public void Exit()
        {
            driver.Close();
        }
    }
}
