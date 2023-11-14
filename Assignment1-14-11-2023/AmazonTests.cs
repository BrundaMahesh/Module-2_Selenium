using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_14_11_2023
{
    internal class AmazonTests
    {
        IWebDriver driver; //Web driver instance
        public void InitializeChromeDriver()
        {
            driver= new ChromeDriver(); //chrome driver initialization
            driver.Url = "https://www.amazon.com/";
            driver.Manage().Window.Maximize();
        }
       
        public void TitleTest()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Title: "+driver.Title);
            Assert.That(driver.Title == "Amazon.com. Spend less. Smile more.");
            Console.WriteLine("Title test - Pass");
        }
        public void OrganisationTypeTest()
        {
            Assert.That(driver.Url.Contains(".com"));
            Console.WriteLine("Organisation type test - Pass");
        }

        public void Destruct()
        {
            driver.Close();
        }
    }
}
