using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rediff.PageObjects
{
    internal class CreateAccountPage
    {
        IWebDriver driver;
        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Arrange
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'name')]")]
        public IWebElement? FullNameText { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'login')]")]
        public IWebElement? rediffmailId { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'btnchkavail')]")]
        public IWebElement? CheckAvailabilityButton { get; set; }

        [FindsBy(How = How.Id, Using ="Register")]
        public IWebElement? CreateMyAccountBtn { get; set; }


        //Act
        public void FullNameType(string fullName)
        {
            FullNameText?.SendKeys(fullName);
        }

        public void RediffmailType(string email)
        {
            rediffmailId?.SendKeys(email);
        }

        public void CheckAvailabilityButtonClick()
        {
            CheckAvailabilityButton?.Click();
        }
        public void CreateMyAccountBtnClick()
        {
            CreateMyAccountBtn?.Click();
        }

        public void FullNameClear()
        {
            FullNameText?.Clear();
        }

        public void RediffmailType()
        {
            rediffmailId?.Clear();
        }

        public void CheckAvailabilityClickClear()
        {
            CheckAvailabilityButton?.Clear();
        }

    }
}
