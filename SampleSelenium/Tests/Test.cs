using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleSelenium.PageObjects;
using SampleSelenium.Tests;
using SampleSelenium.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSelenium
{
    class Test : AbstractTest
    {

        [Test]
        public void OpenAppTest()
        {
            browseInventoryPage.OpenWomenCategory();
            Assert.AreEqual("Faded Short Sleeve T-shirts", browseInventoryPage.getInventoryItemName(0));
            Assert.AreEqual("16.51", browseInventoryPage.getInventoryItemPrice(0));
        }
    
        
    }
}
