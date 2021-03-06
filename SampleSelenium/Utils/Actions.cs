﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSelenium.Utils
{
    public class Actions
    {
        private const int TIMEOUT = 30;
        WebDriverWait wait;
        private IWebDriver driver;

        public Actions(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TIMEOUT));
        }

        public void WaitForPageLoad()
        {
            wait.Until(usedDriver => (string)((IJavaScriptExecutor)usedDriver).ExecuteScript("return document.readyState") == "complete");
        }

        public void OpenPage(string url)
        {
            driver.Url = url;
            WaitForPageLoad();
        }

        public void Click(IWebElement element)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public void ClickAndWaitForNewPageToLoad(IWebElement element)
        {
            Click(element);
            WaitForPageLoad();
        }

        public void EnterText(IWebElement element, string text, By by)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(by));
            element.Clear();
            element.SendKeys(text);
        }
    }


}
