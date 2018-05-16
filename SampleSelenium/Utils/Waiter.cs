using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSelenium.Utils
{
    class Waiter
    {
        private const int TIMEOUT = 30;
        WebDriverWait wait;
        private IWebDriver driver;

        public Waiter(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TIMEOUT));
        }

        public void WaitForPageLoad()
        {
            wait.Until(usedDriver => (string)(((IJavaScriptExecutor)usedDriver).ExecuteScript("return document.readyState")) == "complete");
        }

        public void OpenPage(String url)
        {
            driver.Url = url;
            WaitForPageLoad();
        }

        public void Click(IWebElement element)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }
    }


}
