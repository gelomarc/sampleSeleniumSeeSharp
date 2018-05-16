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

namespace SampleSelenium
{
    class Test
    {
        IWebDriver driver;
        BasePage basePage;
        Waiter waiter;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            basePage = new BasePage(driver);
            waiter = new Waiter(driver);
        }

        [Test]
        public void OpenAppTest()
        {
            waiter.OpenPage("http://automationpractice.com");
            basePage.ClickOnContactLinkButton();
        }
    
        [TearDown]
        public void EndTesT()
        {
            driver.Close();
        }
    }
}
