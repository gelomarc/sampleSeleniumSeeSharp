using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleSelenium.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSelenium
{
    class Test
    {
        IWebDriver driver;
        BasePage basePage;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            basePage = new BasePage(driver);
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://automationpractice.com";
            basePage.contactLinkButton.Click();
        }
    
        [TearDown]
        public void EndTesT()
        {
            driver.Close();
        }
    }
}
