using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleSelenium.PageObjects;
using SampleSelenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSelenium.Tests
{
    public abstract class AbstractTest
    {
        IWebDriver driver;
        public BrowseInventoryPage browseInventoryPage;
        public Waiter waiter;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            browseInventoryPage = new BrowseInventoryPage(driver);
            waiter = new Waiter(driver);
            waiter.OpenPage("http://automationpractice.com");
        }

        [TearDown]
        public void EndTesT()
        {
            driver.Close();
        }
    }
}
