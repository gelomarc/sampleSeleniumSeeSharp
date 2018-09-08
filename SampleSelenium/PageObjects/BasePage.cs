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
        protected Actions actions;
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            actions = new Actions(driver);
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
            actions.ClickAndWaitForNewPageToLoad(contactLinkButton);
        }

        public void EnterTextToSearchBoxAndSearch(String text)
        {
            actions.EnterText(searchBox, text, By.Id("search_query_top"));
            actions.ClickAndWaitForNewPageToLoad(searchButton);
        }

        public void OpenCart()
        {
            actions.ClickAndWaitForNewPageToLoad(shoppingCart);
        }

        public void ClickOnLogo()
        {
            actions.ClickAndWaitForNewPageToLoad(logo);
        }

        public void OpenWomenCategory()
        {
            actions.ClickAndWaitForNewPageToLoad(womenCategory);
        }

        public void OpenDressesCategory()
        {
            actions.ClickAndWaitForNewPageToLoad(dressesCategory);
        }

        public void OpenTShirtsCategory()
        {
            actions.ClickAndWaitForNewPageToLoad(tShirtsCategory);
        }

        public void ClickOnSignIn()
        {
            actions.ClickAndWaitForNewPageToLoad(signIn);
        }

        public void OpenMyAccount()
        {
            actions.ClickAndWaitForNewPageToLoad(openAccount);
        }

        public void ClickOnSignOut()
        {
            actions.ClickAndWaitForNewPageToLoad(signOut);
        }
    }
}
