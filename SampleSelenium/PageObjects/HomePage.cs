using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSelenium.PageObjects
{
    public class BrowseInventoryPage : BasePage
    {
        public BrowseInventoryPage(IWebDriver driver) : base(driver)
        {}

        IReadOnlyCollection<IWebElement> productList;

        public String getInventoryItemName(int index)
        {
            setProductList();
            return productList.ElementAt(index).FindElement(By.XPath(".//a[@class = 'product-name']")).Text;
        }

        public String getInventoryItemPrice(int index)
        {
            setProductList();
            return productList.ElementAt(index).FindElement(By.XPath(".//div[@class= 'right-block']//span[@class = 'price product-price']")).Text.Substring(1);
        }

        private void setProductList()
        {
            productList = driver.FindElements(By.XPath("//ul[starts-with(@class, 'product_list')]/li"));
        }

    }
}
