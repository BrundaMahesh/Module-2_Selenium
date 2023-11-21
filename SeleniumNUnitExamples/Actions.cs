using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitExamples
{
    [TestFixture]
    internal class Actions:CoreCodes
    {
        [Test]
        public void HomeLinkTest()
        {
            IWebElement homelink  = driver.FindElement(By.LinkText("Home"));
            IWebElement tdhomelink = driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[1]/td[1]"));
            
            //Action<> actions = new Actions();
            //Action mouseOverHomeLink = 

        }
    }
}
