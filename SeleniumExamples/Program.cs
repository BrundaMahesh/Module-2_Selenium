using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Url = "https://www.google.com/";
Thread.Sleep(2000);
string title = driver.Title;
//Assert.That(title == "Gooogle");
try
{
    Assert.AreEqual("Gooogle", title);
    Console.WriteLine("Pass");
}
catch(AssertionException)
{
    Console.WriteLine("Fail");
}
driver.Close();