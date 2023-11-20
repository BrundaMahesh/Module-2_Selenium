using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_20_11_2023
{
    internal class CoreCodes
    {
        public IWebDriver driver;
        Dictionary<string, string> properties;

        public void ReadConfigSettings()
        {
            string currDir = Directory.GetParent(@"../../../").FullName;
            properties = new Dictionary<string, string>();
            string fileName = currDir + "/ConfigSettings/Config.properties";
            string[] lines= File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                if(!string.IsNullOrWhiteSpace(line) && line.Contains("="))
                {
                    string[] parts = line.Split('=');
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();
                    properties[key] = value;
                }
            }

        }

        [OneTimeSetUp]
        public void InitBrowser()
        {
            ReadConfigSettings();
            if (properties["browser"].ToLower() == "chrome")
            {
                driver = new ChromeDriver();
            }
            driver.Url = properties["baseUrl"];
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown] 
        public void CleanupBrowser()
        {
            driver.Quit();
        }

    }
}
