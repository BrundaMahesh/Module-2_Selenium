using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
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
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("mobile phones");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
            Assert.That(("Amazon.com : mobile phones".Equals(driver.Title) 
                && (driver.Url.Contains("mobile phones"))));
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
        public void SignInAndAccountListTest()
        {
            IWebElement helloSignIn = driver.FindElement(By.Id("nav-link-accountList-nav-line-1"));
            if(helloSignIn == null)
            {
                throw new NoSuchElementException("Hello, Sign in not present");
            }
            IWebElement accountAndList = driver.FindElement(By.XPath("//*[@id=\"nav-link-accountList\"]/span"));
            if (accountAndList == null)
            {
                throw new NoSuchElementException("Hello, Account and lists is not present");
            }
            Assert.That(helloSignIn.Text.Equals("Hello, sign in"));
            Console.WriteLine("Hello, sign in present - Pass");
            Assert.That(accountAndList.Text.Equals("Account & Lists"));
            Console.WriteLine("Hello, Account & Lists present - Pass");
        }
        public void SearchAndFilterProductByBrandTest()
        {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("mobile phones");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
         
            //Motorola checkbox
            driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div/label/i")).Click();
            Thread.Sleep(3000);
            Assert.True(driver.FindElement(By.XPath("//*[@id=\"p_89/Motorola\"]/span/a/div/label/input")).Selected);
            Console.WriteLine("Motorola is selected");

            //see more
            driver.FindElement(By.ClassName("a-expander-prompt")).Click();
            
            //BLU checkbox
            driver.FindElement(By.XPath("//*[@id=\"p_89/BLU\"]/span/a/div/label/i")).Click();
            Thread.Sleep(3000);
            Assert.True(driver.FindElement(By.XPath("//*[@id=\"p_89/BLU\"]/span/a/div/label/input")).Selected);
            Console.WriteLine("BLU is selected");
        }
        public void SortBySelectTest()
        {
            IWebElement sortBy = driver.FindElement(By.ClassName("a-native-dropdown.a-declarative"));
            SelectElement sortBySelect = (SelectElement)sortBy;
            sortBySelect.SelectByValue("1");
            Thread.Sleep(5000);
            Console.WriteLine((sortBySelect.SelectedOption));
        }
        public void Destruct()
        {
            driver.Close();
        }
    }
}
