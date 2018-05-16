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
    public class BasePage
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

        [FindsBy(How = How.Id, Using = "search_query_top")]
        private IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'shopping_cart']/a")]
        private IWebElement shoppingCart;

        [FindsBy(How = How.XPath, Using = "//button[@name='submit_search']")]
        private IWebElement searchButton;

        [FindsBy(How = How.Id, Using = "header_logo")]
        private IWebElement logo;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'block_top_menu']//a[@title = 'Women']")]
        private IWebElement womenCategory;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'block_top_menu']/ul/li[2]//a[@title = 'Dresses']")]
        private IWebElement dressesCategory;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'block_top_menu']/ul/li[3]//a[@title = 'T-shirts']")]
        private IWebElement tShirtsCategory;

        [FindsBy(How = How.XPath, Using = "//a[@class = 'login']")]
        private IWebElement signIn;

        [FindsBy(How = How.XPath, Using = "//a[@class = 'View my customer account']")]
        private IWebElement openAccount;

        [FindsBy(How = How.XPath, Using = "//*[@title = 'Log me out']")]
        private IWebElement signOut;

        public void ClickOnContactLinkButton()
        {
            waiter.ClickAndWaitForNewPageToLoad(contactLinkButton);
        }

        public void EnterTextToSearchBoxAndSearch(String text)
        {
            waiter.EnterText(searchBox, text, By.Id("search_query_top"));
            waiter.ClickAndWaitForNewPageToLoad(searchButton);
        }

        public void OpenCart()
        {
            waiter.ClickAndWaitForNewPageToLoad(shoppingCart);
        }

        public void ClickOnLogo()
        {
            waiter.ClickAndWaitForNewPageToLoad(logo);
        }

        public void OpenWomenCategory()
        {
            waiter.ClickAndWaitForNewPageToLoad(womenCategory);
        }

        public void OpenDressesCategory()
        {
            waiter.ClickAndWaitForNewPageToLoad(dressesCategory);
        }

        public void OpenTShirtsCategory()
        {
            waiter.ClickAndWaitForNewPageToLoad(tShirtsCategory);
        }

        public void ClickOnSignIn()
        {
            waiter.ClickAndWaitForNewPageToLoad(signIn);
        }

        public void OpenMyAccount()
        {
            waiter.ClickAndWaitForNewPageToLoad(openAccount);
        }

        public void ClickOnSignOut()
        {
            waiter.ClickAndWaitForNewPageToLoad(signOut);
        }
    }
}
