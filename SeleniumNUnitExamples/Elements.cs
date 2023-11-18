using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitExamples
{
    [TestFixture]
    internal class Elements:CoreCodes
    {
        [Test]
        public void TestCheckbox()
        {
            Thread.Sleep(3000);
            //IWebElement elements = driver.FindElement(By.TagName("//h5[text()='Elements']//ancestor::div"));
            //elements.Click();

            IWebElement checkboxmenu = driver.FindElement(By.XPath("//span[text()='Check Box']//parent::li"));
            checkboxmenu.Click();

            
            List<IWebElement> expandCollapse=driver.FindElements(By.XPath("//*[@id=\"tree-node\"]/ol/li/span/button/svg")).ToList();
            foreach (var item in expandCollapse)
            {
                item.Click();
            }
            IWebElement commandsCheckbox = driver.FindElement(By.XPath("//span[text()='Commands']"));
            commandsCheckbox.Click();

            Assert.True(driver.FindElement(By.XPath("//input[contains(@id,'commands')]")).Selected);


        }
    }
}
