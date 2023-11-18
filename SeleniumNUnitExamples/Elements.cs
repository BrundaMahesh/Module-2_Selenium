using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        [Ignore("other")]
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

        [Test]
        public void TestFormsElements()
        {
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("Ashwin");
            Thread.Sleep(2000);


            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Kumar");
            Thread.Sleep(2000);

            IWebElement emailField = driver.FindElement(By.XPath("//input[@id='userEmail']"));
            emailField.SendKeys("ashwinkumar@gmail.com");
            Thread.Sleep(2000);

            IWebElement genderRadio = driver.FindElement(By.XPath("//input[@id='gender-radio-1']//following::label"));
            genderRadio.Click();
            Thread.Sleep(2000);

            IWebElement mobileInputBox = driver.FindElement(By.Id("userNumber"));
            mobileInputBox.SendKeys("12345");
            Thread.Sleep(2000);

            IWebElement dobInputBox = driver.FindElement(By.Id("dateOfBirthInput"));
            dobInputBox.Click();
            Thread.Sleep(2000);

            IWebElement dobMonth = driver.FindElement(By.ClassName("react-datepicker__month-select"));
            SelectElement selectMonth = new SelectElement(dobMonth);
            selectMonth.SelectByIndex(5);
            Thread.Sleep(2000);

            IWebElement dobYear = driver.FindElement(By.ClassName("react-datepicker__year-select"));
            SelectElement selectYear = new SelectElement(dobYear);
            selectYear.SelectByText("1990");
            Thread.Sleep(2000);


            IWebElement dobDay = driver.FindElement(By.XPath("//*[@id=\"dateOfBirth\"]/div[2]/div[2]/div/div/div[2]/div[2]/div[1]/div[6]"));
            dobDay.Click();
            Thread.Sleep(3000);

            IWebElement subjectInputBox = driver.FindElement(By.Id("subjectsInput"));
            subjectInputBox.SendKeys("Maths");
            subjectInputBox.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            subjectInputBox.SendKeys("Chemistry");
            subjectInputBox.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            IWebElement sportsHobbiesCheckBox = driver.FindElement(By.XPath("//label[text()='Sports']"));
            sportsHobbiesCheckBox.Click();
            Thread.Sleep(2000);

            IWebElement uploadPicture = driver.FindElement(By.Id("uploadPicture"));
            uploadPicture.SendKeys("C:\\Users\\Administrator\\Downloads\\download.jpg");
            Thread.Sleep(2000);

            IWebElement currentAddressField = driver.FindElement(By.Id("currentAddress"));
            currentAddressField.SendKeys("123 street, Chennai");
            Thread.Sleep(2000);

            //IWebElement submitButton = driver.FindElement(By.Id("submit"));
            //submitButton.Click();
        }
    }
}
