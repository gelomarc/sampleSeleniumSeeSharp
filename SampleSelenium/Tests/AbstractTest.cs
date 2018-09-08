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
        public Actions Actions;

        [SetUp]
        public void Initialize()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless");
            driver = new ChromeDriver(options);
            browseInventoryPage = new BrowseInventoryPage(driver);
            Actions = new Actions(driver);
            Actions.OpenPage("http://automationpractice.com");
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
