using BunnyCart.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCart.TestScripts
{
    [TestFixture]
    internal class SearchTests:CoreCodes
    {
        [Test]
        [TestCase("Water")]
        public void SearchProductAndAddToCartTest(string searchtext)
        {
            BunnyCartHomePage bchp = new BunnyCartHomePage(driver);
            var searchResultPage = bchp?.TypeSearchInput(searchtext);
            CoreCodes.ScrollIntoView(driver,driver.FindElement(By.XPath("//*[@id=\'amasty-shopby-product-list\']/div[2]/ol/li[1]")));
            Assert.That(searchtext.Equals(searchResultPage?.GetFirstProductLink()));

            var productPage = searchResultPage?.ClickFirstProductLink();
            Assert.That(searchtext.Equals(productPage?.GetProductTitleLabel()));
            productPage?.ClickIncQtyLink();
            productPage?.ClickAddToCartBtn();

            Thread.Sleep(5000);
        }
    }
}
