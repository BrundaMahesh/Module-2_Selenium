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
        }
        public void InitializeEdgeDriver()
        {
            driver = new EdgeDriver();
            driver.Url = "https://www.google.com/";
        }
        public void TitleTest()
        {
            Thread.Sleep(2000);
            string title = driver.Title;
            Assert.AreEqual("Google", title);
            Console.WriteLine("Title test - Pass");
        }

        public void Destruct()
        {
            driver.Close();
        }
    }
}
