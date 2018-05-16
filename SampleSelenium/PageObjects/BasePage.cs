using OpenQA.Selenium;
using SampleSelenium.Utils;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSelenium.PageObjects
{
    class BasePage
    {
        protected Waiter waiter;
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            this.waiter = new Waiter(driver);
        }

        [FindsBy(How = How.Id, Using = "contact-link")]
        private IWebElement contactLinkButton;

        public void ClickOnContactLinkButton()
        {
            waiter.Click(contactLinkButton);
        }
    }
}
