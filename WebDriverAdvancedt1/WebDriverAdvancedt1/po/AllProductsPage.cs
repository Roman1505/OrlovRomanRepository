using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverAdvanced.po
{
    class AllProductsPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public AllProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement clickButton => driver.FindElement(By.LinkText("Create new"));
        public ProductEditingPage GoToPage()
        {
            new Actions(driver).MoveToElement(clickButton).Click(clickButton).Build().Perform();
            return new ProductEditingPage(driver);
        }
    }
}
