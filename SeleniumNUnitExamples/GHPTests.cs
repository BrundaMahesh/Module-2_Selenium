﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitExamples
{
    [TestFixture]
    internal class GHPTests:CoreCodes
    {
        [Test]
        [Order(0)]
        public void TitleTest()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Title: " + driver.Title);
            Console.WriteLine("Title length: " + driver.Title.Length);
            Assert.AreEqual("Google", driver.Title);
            Console.WriteLine("Title test - Pass");
        }
        [Test]
        [Order(1)]
        public void GSTest()
        {
            IWebElement searchInputTextBox = driver.FindElement(By.Id("APjFqb"));
            searchInputTextBox.SendKeys("Dell laptop");
            Thread.Sleep(2000);
            IWebElement gsButton = driver.FindElement(By.ClassName("gNO89b"));
            gsButton.Click();
            Assert.AreEqual("Dell laptop - Google Search", driver.Title);
            Console.WriteLine("GS test - Pass");
        }
        [Test]
        [Order(2)]
        public void AllLinksStatusTest()
        {
            List<IWebElement> allLinks=driver.FindElements(By.TagName("a")).ToList();
            foreach (var link in allLinks)
            {
                string url= link.GetAttribute("href");
                if(url==null)
                {
                    Console.WriteLine("URL is null");
                    continue;
                }
                else
                {
                    bool isWorking = CheckLinkStatus(url);
                    if(isWorking)
                    {
                        Console.WriteLine(url + " is working");
                    }
                    else
                    {
                        Console.WriteLine(url + " is not working");
                    }
                }
            }
        }

    }
}
